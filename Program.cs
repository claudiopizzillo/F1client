using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
                    hubConnection.TraceLevel = TraceLevels.All;
                    hubConnection.TraceWriter = Console.Out;
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

                    f1timing.On("StreamingStatus", () => Console.WriteLine("Notified!"));

                    await hubConnection.Start();

                    try {
                        var result = f1timing.Invoke<RootObject>("Subscribe", subscriptions).Result;
                        Console.WriteLine("STATUS {0}",result.StreamingStatus.Status.ToString());
                        Console.WriteLine("CIRCUIT {0}", result.SPFeed.free.data.R);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex);
                    }



                    Console.ReadLine();


                }
            }
        }

    }

}

