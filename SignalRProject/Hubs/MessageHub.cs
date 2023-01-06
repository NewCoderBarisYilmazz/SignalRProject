using Microsoft.AspNetCore.SignalR;

namespace SignalRProject.Hubs
{
    public class MessageHub:Hub
    {

      



    }

    public class MessageHubService
    {
        private readonly IHubContext<MessageHub> _hubcontext;

        public MessageHubService(IHubContext<MessageHub> hubcontext)
        {
            _hubcontext = hubcontext;
        }


        public async Task SendMessage(string message)
        {
            await _hubcontext.Clients.All.SendAsync("SendMessage",message);


        }
    }
}
