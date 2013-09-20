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

        public event EventHandler ClientExited;
        public event EventHandler<ClientReceivedDataEventArgs> DataReceived;

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

            if (_proc == null)
                return;

            _procId = _proc.Id;

            _proc.Exited += (sender, e) =>
            {
                if (ClientExited != null)
                    ClientExited(this, EventArgs.Empty);
            };

            _proc.BeginOutputReadLine();
            _proc.BeginErrorReadLine();

            _proc.OutputDataReceived += ProcessStandard;
            _proc.ErrorDataReceived += ProcessError;

        }

        private void ProcessStandard(object sender, DataReceivedEventArgs e)
        {
            if (DataReceived != null)
                DataReceived(this, new ClientReceivedDataEventArgs(e.Data));
        }

        private void ProcessError(object sender, DataReceivedEventArgs e)
        {
            if (DataReceived != null)
                DataReceived(this, new ClientReceivedDataEventArgs(e.Data));
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

    public class ClientReceivedDataEventArgs : EventArgs
    {

        public string Data { get; set; }

        public ClientReceivedDataEventArgs(string data)
        {
            Data = data;
        }

    }

}
