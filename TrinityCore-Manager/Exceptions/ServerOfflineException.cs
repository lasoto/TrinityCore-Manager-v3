using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Exceptions
{
    public class ServerOfflineException : Exception
    {

        public ServerOfflineException()
            : base("The server is offline!")
        {
        }

    }
}
