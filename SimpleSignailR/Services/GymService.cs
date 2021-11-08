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

        public void AddUser()
        {
            usersInGym += 1;
        }

        public void RemoveUser()
        {
            usersInGym -= 1;
        }

        public int GetTotalUsersInGym()
        {
            return usersInGym;
        }
    }
}
