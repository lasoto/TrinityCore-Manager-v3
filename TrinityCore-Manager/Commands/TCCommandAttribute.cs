using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Commands
{
    [AttributeUsage(AttributeTargets.Field)]
    class TCCommandAttribute : Attribute
    {

        public string CommandName { get; set; }
        public int ParamsNum { get; set; }

        public TCCommandAttribute(string commandName, int paramsNum)
        {
            CommandName = commandName;
            ParamsNum = paramsNum;
        }

    }
}
