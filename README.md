# f1client
Simple F1 live timing client

Hi guys, i decoded the new F1 live timing service : it use Signalr protocol to push data to the web (or others) clients.

1. For now it show simple data for a race or qualifing session (or testing).
2. Need a valid account on Formula1.com website.
2. The Signalr protocol is incompatible with Signalr NET Core protocol, need .Net framework 4.7.2.
3. To start the client from console: f1client-net YOURF1USERNAME YOURF1PASSWORD