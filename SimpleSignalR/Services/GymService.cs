using Microsoft.AspNetCore.SignalR;
using SimpleSignailR.Hubs;
using SimpleSignailR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSignailR.Services
{
    public class GymService : IGymService
    {
        private int usersInGym;
        private readonly IHubContext<SignalRHub> _hubContext;

        public GymService(IHubContext<SignalRHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public void AddUser()
        {
            usersInGym += 1;
            _hubContext.Clients.All.SendAsync("ReceiveMessage", usersInGym);
        }

        public void RemoveUser()
        {
            usersInGym -= 1;
            _hubContext.Clients.All.SendAsync("ReceiveMessage", usersInGym);
        }

        public int GetTotalUsersInGym()
        {
            return usersInGym;
        }
    }
}
