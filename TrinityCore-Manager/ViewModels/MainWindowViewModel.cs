using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;

        public Command ExecuteConsoleCommand { get; private set; }

        public MainWindowViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService)
        {

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;

            ExecuteConsoleCommand = new Command(ExecConsoleCommand);

        }

        private async void ExecConsoleCommand()
        {

            ConsoleCommand = String.Empty;

            if (TCManager.Instance.Online)
                await TCAction.ExecuteCommand(ConsoleCommand);

        }

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
