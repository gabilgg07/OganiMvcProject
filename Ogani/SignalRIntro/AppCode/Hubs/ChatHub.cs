using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRIntro.AppCode.Hubs
{
    public class ChatHub : Hub
	{
        static ConcurrentDictionary<string,string> users = new ConcurrentDictionary<string, string>();

        public override Task OnConnectedAsync()
        {
            //Debug.WriteLine($">>>>> {Context.ConnectionId} <<<<<");

            var ctx = Context.GetHttpContext();

            string email = ctx.Request.Query["yourKey"].ToString();

            users.TryAdd(email, Context.ConnectionId);

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        public Task SendToFriend(string to, string message)
        {
            if (users.TryGetValue(to, out string clientId))
            {
                var email = users.FirstOrDefault(u => u.Value.Equals(Context.ConnectionId)).Key;
                Clients.Client(clientId).SendAsync("messageReceive", email, message);
            }
            return Task.CompletedTask;
        }
    }
}

