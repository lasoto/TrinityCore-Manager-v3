using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.ViewModels.Wizard;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Core;

namespace TrinityCore_Manager.ViewModels
{
    [InterestedIn(typeof(WizardConnectOptionViewModel))]
    [InterestedIn(typeof(WizardTrinityServerFolderViewModel))]
    [InterestedIn(typeof(WizardRADetailsViewModel))]
    public class SetupWizardViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;

        private string _serverPath;

        private string _raHost;
        private int _raPort;
        private string _raUsername;
        private string _raPassword;

        public Command<CancelRoutedEventArgs> Next { get; private set; }

        public Command<CancelRoutedEventArgs> Previous { get; private set; }

        public Command<CancelRoutedEventArgs> Finish { get; private set; }

        public SetupWizardViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            _serverPath = String.Empty;

            _raHost = String.Empty;
            _raPort = 0;
            _raUsername = String.Empty;
            _raPassword = String.Empty;

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            Next = new Command<CancelRoutedEventArgs>(NextButtonPressed);
            Previous = new Command<CancelRoutedEventArgs>(PreviousButtonPressed);
            Finish = new Command<CancelRoutedEventArgs>(FinishButtonPressed);

        }

        private void NextButtonPressed(CancelRoutedEventArgs e)
        {

            var wizard = e.Source as Xceed.Wpf.Toolkit.Wizard;

            if (wizard != null)
            {

                string page = wizard.CurrentPage.Name.ToLower();

                if (page == "connectoptionpage")
                {
                }
                else if (page == "trinityinfo")
                {

                    if (Local)
                    {

                        if (string.IsNullOrEmpty(_serverPath))
                        {

                            _messageService.ShowError("Server path cannot be empty!");

                            e.Cancel = true;

                        }

                    }
                    else
                    {

                        if (string.IsNullOrEmpty(_raHost) || string.IsNullOrEmpty(_raUsername) || string.IsNullOrEmpty(_raPassword))
                        {

                            _messageService.ShowError("All fields must be filled out!");

                            e.Cancel = true;

                        }

                    }

                }

            }

        }

        private void PreviousButtonPressed(CancelRoutedEventArgs e)
        {

            var wizard = e.Source as Xceed.Wpf.Toolkit.Wizard;

            if (wizard != null)
            {

                string page = wizard.CurrentPage.Name.ToLower();

            }

        }

        private void FinishButtonPressed(CancelRoutedEventArgs e)
        {

            var wizard = e.Source as Xceed.Wpf.Toolkit.Wizard;

            if (wizard != null)
            {
            }

        }

        protected override void OnViewModelPropertyChanged(IViewModel viewModel, string propertyName)
        {

            if (viewModel is WizardConnectOptionViewModel)
            {

                var model = (WizardConnectOptionViewModel)viewModel;

                if (model.ConnectLocally)
                    Local = true;
                else if (model.ConnectRemotely)
                    Local = false;

            }
            else if (viewModel is WizardTrinityServerFolderViewModel)
            {

                var model = (WizardTrinityServerFolderViewModel)viewModel;

                _serverPath = model.ServerFolderLocation;

            }
            else if (viewModel is WizardRADetailsViewModel)
            {

                var model = (WizardRADetailsViewModel)viewModel;

                _raHost = model.Host;
                _raPort = model.Port;
                _raUsername = model.Username;
                _raPassword = model.Password;

            }


        }

        public bool Local
        {
            get
            {
                return GetValue<bool>(LocalProperty);
            }
            set
            {
                SetValue(LocalProperty, value);
            }
        }

        public static PropertyData LocalProperty = RegisterProperty("Local", typeof(bool), true);

    }
}
