
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace SimpleBroadCast.Hubs
{
    public class ChatHub : Hub
    {

        public async Task Send(string heading, string message)
        {
            await Clients.All.SendAsync("recieve", heading, message);
        }
    }
}
