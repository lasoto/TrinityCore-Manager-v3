using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.TCM
{
    public abstract class TCMClient
    {

        public abstract bool IsOnline { get; }

        public abstract void Start();

        public abstract void Stop();

        public abstract Task SendMessage(string message);

    }
}
