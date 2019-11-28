using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using static F1Client_net.TimingData;

namespace F1Client_net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F1 live timing client started!");
            Task.Run(Run).Wait();
        }

        static async Task Run()
        {

            while (true)
            {


                using (var hubConnection = new HubConnection("https://livetiming.formula1.com/signalr"))
                {
                    //hubConnection.TraceLevel = TraceLevels.All;
                    //hubConnection.TraceWriter = Console.Out;
                    hubConnection.ConnectionSlow += () => Console.WriteLine("Connection problems.");
                    hubConnection.Error += ex => Console.WriteLine("SignalR error: {0}", ex.Message);
                    hubConnection.Received += data => Console.WriteLine("MESSAGE RECEIVED {0}", data.ToString());
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
                        var result = f1timing.Invoke<RootObject>("Subscribe", subscriptions).Result;
                        Console.WriteLine("STATUS {0}",result.StreamingStatus.Status.ToString());
                        Console.WriteLine("CIRCUIT {0}", result.SPFeed.free.data.R);
                        RenderFreeData(result);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex);
                    }



                    Console.ReadLine();


                }
            }
        }


        static void RenderFreeData(RootObject mydata)
        {
            var rtdata = mydata.SPFeed.free.data;
            Console.WriteLine("TOTAL LAPS: {0}. CURRENT LAP {1}", rtdata.TL, rtdata.L);
            var positions = rtdata.DR;
            //var ordered = positions.OrderByDescending(x => x.F.ElementAt(4)).ToList();
            var ordered = from x in positions orderby x.F.ElementAt(3).Length, x.F.ElementAt(3) ascending select x;
            foreach (var item in ordered)
            {
                Console.WriteLine("{0} {1} {2}", item.F.ElementAt(3), item.F.ElementAt(0), item.F.ElementAt(4));
            }
        }
    }

}

