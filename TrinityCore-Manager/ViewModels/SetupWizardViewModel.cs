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
    public class SetupWizardViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;

        public Command<CancelRoutedEventArgs> Next { get; private set; }

        public SetupWizardViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService)
        {

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;

            Next = new Command<CancelRoutedEventArgs>(NextButtonPressed);

        }

        private void NextButtonPressed(CancelRoutedEventArgs e)
        {

            

        }

        protected override void OnViewModelPropertyChanged(IViewModel viewModel, string propertyName)
        {

            if (viewModel is WizardConnectOptionViewModel)
            {

                var model = (WizardConnectOptionViewModel)viewModel;

                Console.WriteLine(Page.Name);

            }


        }

        public WizardPage Page
        {
            get
            {
                return GetValue<WizardPage>(PageProperty);
            }
            set
            {
                SetValue(PageProperty, value);
            }
        }

        public static readonly PropertyData PageProperty = RegisterProperty("Page", typeof(WizardPage));

    }
}
