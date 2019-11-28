# f1client
Simple F1 live timing client

Hi guys, i decoded the new F1 live timing service : it use Signalr protocol to push data to the web (or others) clients.

1. For now it show the Signalr connection status, the streaming status (Online and Offline) and other simple datas, but we get every data available.
2. The Signalr protocol is incompatible with Signalr NET Core protocol, need .net framework 4.7.2.
3. Uncomment //hubConnection.TraceLevel = TraceLevels.All; //hubConnection.TraceWriter = Console.Out; to show data exchange.