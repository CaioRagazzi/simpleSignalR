using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSignailR.Hubs
{
    public class SignalRHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("--> User connected! " + Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            Console.WriteLine("--> User disconnected! " + Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
