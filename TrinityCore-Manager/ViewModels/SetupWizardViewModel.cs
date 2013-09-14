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
    public class SetupWizardViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;

        private bool _isLocal;

        private string _serverPath;

        public Command<CancelRoutedEventArgs> Next { get; private set; }

        public SetupWizardViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            _isLocal = false;

            _serverPath = String.Empty;

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            Next = new Command<CancelRoutedEventArgs>(NextButtonPressed);

        }

        private void NextButtonPressed(CancelRoutedEventArgs e)
        {

            var wizard = e.Source as Xceed.Wpf.Toolkit.Wizard;

            if (wizard != null)
            {

                string page = wizard.CurrentPage.Name.ToLower();

                if (page == "connectoptionpage")
                {

                    //e.Cancel = true;

                }
                else if (page == "trinityserverfolder")
                {

                    if (string.IsNullOrEmpty(_serverPath))
                    {

                        _messageService.ShowError("Server path cannot be empty!");

                        e.Cancel = true;

                    }

                }

            }

        }

        protected override void OnViewModelPropertyChanged(IViewModel viewModel, string propertyName)
        {

            if (viewModel is WizardConnectOptionViewModel)
            {

                var model = (WizardConnectOptionViewModel)viewModel;

                if (model.ConnectLocally)
                    _isLocal = true;
                else if (model.ConnectRemotely)
                    _isLocal = false;

            }
            else if (viewModel is WizardTrinityServerFolderViewModel)
            {

                var model = (WizardTrinityServerFolderViewModel)viewModel;

                _serverPath = model.ServerFolderLocation;

            }


        }

    }
}
