using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database
{
    interface IDatabase
    {
        void CleanupAccounts(DateTime date);
    }
}
