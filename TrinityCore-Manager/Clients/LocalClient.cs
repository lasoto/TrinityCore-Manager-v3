using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.Clients
{
    public class LocalClient : TCMClient
    {

        private Process _proc;

        public Process UnderlyingProcess
        {
            get
            {
                return _proc;
            }
        }

        public int UnderlyingProcessId
        {
            get
            {
                return _procId;
            }
        }

        private int _procId = -1;

        private readonly string _exeFile;
        private readonly string _exeArgs;

        public LocalClient(string exeFile, string args = "")
        {
            _exeFile = exeFile;
            _exeArgs = args;
        }

        public override bool IsOnline
        {
            get { return _proc != null && !_proc.HasExited && ProcessHelper.ProcessExists(_procId); }
        }

        public override void Start()
        {
            _proc = ProcessHelper.StartProcess(_exeFile, Path.GetDirectoryName(_exeFile), _exeArgs);
            _procId = _proc.Id;
        }

        public override void Stop()
        {
            ProcessHelper.KillProcess(_procId);
        }

        public override async Task SendMessage(string message)
        {

            StreamWriter writer = _proc.StandardInput;

            await writer.WriteLineAsync(message);

        }

    }
}
