using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.Clients;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;

        public Command ExecuteConsoleCommand { get; private set; }

        public Command StartServerCommand { get; private set; }

        public MainWindowViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService)
        {

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;

            ExecuteConsoleCommand = new Command(ExecConsoleCommand);
            StartServerCommand = new Command(StartServer);

        }

        private void StartServer()
        {

            TCManager inst = TCManager.Instance;

            IMessageService imsgs = GetService<IMessageService>();

            //if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "authserver.exe")))
            //{

            //    imsgs.ShowError(new Exception("The file authserver.exe does not exist!"));

            //    return;

            //}

            //if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe")))
            //{

            //    imsgs.ShowError(new Exception("The file worldserver.exe does not exist!"));

            //    return;

            //}

            if (inst.AuthClient != null)
            {
                if (inst.AuthClient.IsOnline)
                {

                    MessageResult result = imsgs.Show("Authserver is already running! Kill it?", "Kill it?", MessageButton.YesNo, MessageImage.Question);

                    if (result == MessageResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.AuthClient).UnderlyingProcessId);
                
                }
            }

            if (inst.WorldClient != null)
            {
                if (inst.WorldClient.IsOnline)
                {

                    MessageResult result = imsgs.Show("Worldserver is already running! Kill it?", "Kill it?", MessageButton.YesNo, MessageImage.Question);

                    if (result == MessageResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.WorldClient).UnderlyingProcessId);
                
                }
            }

            //var authClient = new LocalClient(Path.Combine(Settings.Default.ServerFolder, "authserver.exe"));
            //var worldClient = new LocalClient(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe"));

            //inst.AuthClient = authClient;
            //inst.WorldClient = worldClient;

            //inst.AuthClient.Start();
            //inst.WorldClient.Start();

            ServerOnline = true;

        }

        private async void ExecConsoleCommand()
        {

            ConsoleCommand = String.Empty;

            if (TCManager.Instance.Online)
                await TCAction.ExecuteCommand(ConsoleCommand);

        }

        public bool ServerOnline
        {
            get
            {
                return GetValue<bool>(ServerOnlineProperty);
            }
            set
            {
                SetValue(ServerOnlineProperty, value);
            }
        }

        public static readonly PropertyData ServerOnlineProperty = RegisterProperty("ServerOnline", typeof(bool));

        public string ConsoleCommand
        {
            get
            {
                return GetValue<string>(ConsoleCommandProperty);
            }
            set
            {
                SetValue(ConsoleCommandProperty, value);
            }
        }

        public static readonly PropertyData ConsoleCommandProperty = RegisterProperty("ConsoleCommand", typeof(string));

    }
}
