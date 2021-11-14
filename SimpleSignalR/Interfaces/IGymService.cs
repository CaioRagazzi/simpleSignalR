using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSignailR.Interfaces
{
    public interface IGymService
    {
        void AddUser();
        void RemoveUser();
        int GetTotalUsersInGym();
    }
}
