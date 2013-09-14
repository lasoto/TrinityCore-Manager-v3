using TrinityCore_Manager.ViewModels.Wizard;

namespace TrinityCore_Manager.Views.Wizard
{
    using Catel.Windows.Controls;

    /// <summary>
    /// Interaction logic for WizardConnectOptionPage.xaml.
    /// </summary>
    public partial class WizardConnectOptionView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardConnectOptionView"/> class.
        /// </summary>
        public WizardConnectOptionView()
        {
            InitializeComponent();
        }

        protected override System.Type GetViewModelType()
        {
            return typeof(WizardConnectOptionViewModel);
        }

    }
}
