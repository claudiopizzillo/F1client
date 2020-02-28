using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using static F1Client_net.TimingData;
//using static F1Client_net.TimingData2;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Net.Http;
using RestSharp;
using System.Threading;

namespace F1Client_net
{

    class Program
    {
        public static Authentication.RootObject authdata;
        static void Main(string[] args)
        {
            string username = args[0];
            string password = args[1];


            CookieContainer cookieJar = new CookieContainer();
            RestClient client = new RestClient(@"https://account.formula1.com/scripts/main.min.js");
            client.CookieContainer = cookieJar;
            RestRequest req = new RestRequest(Method.GET);
            req.AddHeader("User-Agent", "Mozilla / 5.0(Windows NT 10.0; …) Gecko / 20100101 Firefox / 74.0");
            IRestResponse res = client.Execute(req);

            int StatusCode = (int)res.StatusCode;
            if (StatusCode != 200)
            {
                Console.WriteLine("KO getting start page");
                return;
            }




            string apikey = getBetween(res.Content, "apikey:\"","\",");
            string distributionChannel = getBetween(res.Content, "distributionChannel:\"", "\",");


            client = new RestClient(@"https://api.formula1.com/v2/account/subscriber/authenticate/by-password");
            client.CookieContainer = cookieJar;
            req = new RestRequest(Method.POST);
            req.AddHeader("User-Agent", "Mozilla / 5.0(Windows NT 10.0; …) Gecko / 20100101 Firefox / 74.0");
            req.AddHeader("apiKey", apikey);
            req.RequestFormat = DataFormat.Json;
            req.AddJsonBody(new { Login = username, Password = password, DistributionChannel = distributionChannel });

            authdata = client.Execute<Authentication.RootObject>(req).Data;
            
            StatusCode = (int)res.StatusCode;
            if (StatusCode != 200)
            {
                Console.WriteLine("KO posting auth data");
                return;
            }


            Console.WriteLine("F1 live timing client started!");
            Task.Run(Run).Wait();
        }

        static async Task Run()
        {

            while (true)
            {


                using (var hubConnection = new HubConnection("https://livetiming.formula1.com/signalr"))
                {
                    var root = new RootObject();
                    var writer = new StreamWriter("ClientLog.txt")
                    {
                        AutoFlush = true
                    };
                    hubConnection.TraceLevel = TraceLevels.All;
                    hubConnection.TraceWriter = Console.Out;
                    hubConnection.TraceWriter = writer;

                    Cookie authCookie = new Cookie
                    {
                        Domain = "formula1.com",
                        Name = "account-info",
                        Value = "\"SubscriberId\":\""+ authdata.Subscriber.Id +"\",\"SubscribedProduct\":\"\",\"SubscriptionStatus\":\""+ authdata.data.subscriptionStatus + "\",\"country\":\""+ authdata.Subscriber.HomeCountry+ "\",\"firstName\":\""+ authdata.Subscriber.FirstName+ "\",\"lastName\":\""+ authdata.Subscriber.LastName+ "\""
                    };

                    hubConnection.CookieContainer = new CookieContainer();
                    hubConnection.CookieContainer.Add(authCookie);

                    hubConnection.ConnectionSlow += () => Console.WriteLine("Connection problems.");
                    hubConnection.Error += ex => Console.WriteLine("SignalR error: {0}", ex.Message);
                    hubConnection.Received += data => updatedata(root, data);
                    hubConnection.Reconnecting += () => Console.WriteLine("Reconnecting.");
                    hubConnection.Reconnected += () => Console.WriteLine("Reconnected.");
                    hubConnection.StateChanged += change =>
                    {
                        Console.WriteLine(change.NewState);
                    };

                    List<string> subscriptions = new List<string>();
                    subscriptions.Add("SPFeed");
                    subscriptions.Add("ExtrapolatedClock");
                    subscriptions.Add("StreamingStatus");

                    var f1timing = hubConnection.CreateHubProxy("Streaming");
                    await hubConnection.Start();


                    try {
                        root = f1timing.Invoke<RootObject>("Subscribe", subscriptions).Result;
                        RenderFreeData(root); 
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex);
                    }

                    Console.ReadLine();

                }
            }
        }

        static void updatedata(RootObject root, string data)
        {
            //Console.WriteLine("MESSAGE RECEIVED {0}", data);
            var tempobj = JObject.Parse(data);
            string res = ApplyPatch(tempobj["A"].ToString());
            var obj = JObject.Parse(res);
            var name = obj.Properties().Select(p => p.Name).FirstOrDefault();

            switch (name)
            {
                case "opt":
                    Opt opt = root.SPFeed.opt;
                    if (obj["opt"]["data"]["DR"] != null)
                    {
                        IList<JToken> DR = JObject.Parse(obj["opt"]["data"]["DR"].ToString());
                        var DRindex = Convert.ToInt32(((JProperty)DR[0]).Name);
                        var O = ((JProperty)DR[0]).Value;

                        JToken Otemp = JToken.Parse(O.ToString());
                        if (Otemp["O"] != null)
                        {
                            var Oindex = Otemp["O"];
                            foreach (JToken item in Oindex)
                            {
                                int index = Convert.ToInt32(((JProperty)item).Name);
                                string value = ((JProperty)item).Value.ToString();
                                //Console.WriteLine("Index {0} Value {1}", index, value);
                                root.SPFeed.opt.data.DR[DRindex].O[index] = value;
                            }
                        }
                    };
                    RenderFreeData(root);
                    break;
                case "best":
                    Best best = root.SPFeed.best;
                    if (obj["best"]["data"]["DR"] != null)
                    {
                        IList<JToken> DR = JObject.Parse(obj["best"]["data"]["DR"].ToString());
                        var DRindex = Convert.ToInt32(((JProperty)DR[0]).Name);
                        var B= ((JProperty)DR[0]).Value;

                        JToken Btemp = JToken.Parse(B.ToString());
                        if (Btemp["B"] != null)
                        {
                            var Bindex = Btemp["B"];
                            foreach (JToken item in Bindex)
                            {
                                int index = Convert.ToInt32(((JProperty)item).Name);
                                string value = ((JProperty)item).Value.ToString();
                                //Console.WriteLine("Index {0} Value {1}", index, value);
                                root.SPFeed.best.data.DR[DRindex].B[index] = value;
                            }
                        }
                    };
                    RenderFreeData(root);
                    break;
                case "sq":
                    break;
                case "Weather":
                    break;
            };


        }




        static void RenderFreeData(RootObject mydata)
        {
            Console.Clear();
            Console.WriteLine("STATUS {0}", mydata.StreamingStatus.Status.ToString());
            Console.WriteLine("CIRCUIT {0}", mydata.SPFeed.free.data.R);
            var initdata = mydata.SPFeed.init.data;
            var bestdata = mydata.SPFeed.best.data;
            var optdata = mydata.SPFeed.opt.data;
            var freedata = mydata.SPFeed.free.data;

            //create new datatable
            var firstcombine = (freedata.S == "Race") ?
            initdata.Drivers.Zip(optdata.DR, (a, b) => new
            {
                a.FullName,
                a.Initials,
                a.Num,
                Gap = b.O.ElementAtOrDefault(9),
                Interval = b.O.ElementAtOrDefault(14),
                Lap = b.O.ElementAtOrDefault(1),
                S1 = b.O.ElementAtOrDefault(5),
                S2 = b.O.ElementAtOrDefault(6),
                S3 = b.O.ElementAtOrDefault(7),
                SP1 = b.O.ElementAtOrDefault(10),
                SP2 = b.O.ElementAtOrDefault(11),
                SP3 = b.O.ElementAtOrDefault(12),
                SP4 = b.O.ElementAtOrDefault(13),
                PIT = b.O.ElementAtOrDefault(3)
            }) :
            initdata.Drivers.Zip(bestdata.DR, (a, b) => new
            {
                a.FullName,
                a.Initials,
                a.Num,
                Gap = b.B == null ? 0 : b.B.ElementAtOrDefault(9),
                Interval = b.B == null ? 0: b.B.ElementAtOrDefault(14),
                Lap = b.B == null ? 0 : b.B.ElementAtOrDefault(1),
                S1 = b.B == null ? 0 : b.B.ElementAtOrDefault(4),
                S2 = b.B == null ? 0 : b.B.ElementAtOrDefault(7),
                S3 = b.B == null ? 0 : b.B.ElementAtOrDefault(10),
                SP1 = b.B == null ? 0 : b.B.ElementAtOrDefault(13),
                SP2 = b.B == null ? 0 : b.B.ElementAtOrDefault(16),
                SP3 = b.B == null ? 0 : b.B.ElementAtOrDefault(19),
                SP4 = b.B == null ? 0 : b.B.ElementAtOrDefault(22),
                PIT = b.B == null ? 0 : b.B.ElementAtOrDefault(3)
            });  ;



            var secondcombine = (freedata.S == "Race") ?
                firstcombine.Zip(freedata.DR, (a, b) => new
                {
                    POS = b.F.ElementAt(3),
                    a.FullName,
                    a.Initials,
                    a.Num,
                    a.Gap,
                    a.Interval,
                    a.Lap,
                    a.S1,
                    a.S2,
                    a.S3,
                    a.SP1,
                    a.SP2,
                    a.SP3,
                    a.SP4,
                    a.PIT
                }) :
                    firstcombine.Zip(bestdata.DR, (a, b) => new
                    {
                    POS = b.B.ElementAt(3),
                    a.FullName,
                    a.Initials,
                    a.Num,
                    a.Gap,
                    a.Interval,
                    a.Lap,
                    a.S1,
                    a.S2,
                    a.S3,
                    a.SP1,
                    a.SP2,
                    a.SP3,
                    a.SP4,
                    a.PIT
                    });


            var ordered = from x in secondcombine orderby x.POS == null, x.POS ascending select x;


            Console.WriteLine(new string('-', 100));

            Console.WriteLine("TOTAL LAPS: {0}. CURRENT LAP {1}", freedata.TL, freedata.L);

            Console.WriteLine(new string('-', 100));

            foreach (var item in ordered)
            {
                string gap; //check if winner
                string interval;
                if (freedata.S == "Race")
                {
                    //gap = "LAP";
                    //interval = freedata.TL.ToString() ?? "";
                    Console.WriteLine("{0,2} {1,2} {2,12} {3,3} {4,8} {5,7} {6,10} {7,6} {8,6} {9,6} {10,3} {11,3} {12,3} {13,3} {14,1}", item.POS, item.Num, item.FullName, item.Initials, item.Gap, item.Interval, item.Lap, item.S1, item.S2, item.S3, item.SP1, item.SP2, item.SP3, item.SP4, item.PIT);
                }
                else
                {
                    //gap = item.Gap.ToString() ?? "";
                    //interval = item.Interval?.ToString() ?? "";
                    Console.WriteLine("{0,2} {1,2} {2,12} {3,3} {4,10} {5,6} {6,6} {7,6} {8,3} {9,3} {10,3} {11,3}", item.POS, item.Num, item.FullName, item.Initials, item.Lap, item.S1, item.S2, item.S3, item.SP1, item.SP2, item.SP3, item.SP4);

                }

            }
        }


        public static string ApplyPatch(string msg)
        {
            string feed = Regex.Matches(msg, "\\\"(.*?)\\\"")[0].ToString();
            if (feed.Trim('"') == "SPFeed")
            {
                return msg.Substring(msg.IndexOf(",") + 1, msg.LastIndexOf(",") - msg.IndexOf(",") - 1).Trim();
            }
            else
            {
                return null;
            };
        }

        static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }

}

