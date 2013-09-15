using TrinityCore_Manager.ViewModels.Wizard;

namespace TrinityCore_Manager.Views.Wizard
{
    using Catel.Windows.Controls;

    /// <summary>
    /// Interaction logic for WizardRADetailsView.xaml.
    /// </summary>
    public partial class WizardRADetailsView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardRADetailsView"/> class.
        /// </summary>
        public WizardRADetailsView()
        {
            InitializeComponent();
        }

        protected override System.Type GetViewModelType()
        {
            return typeof(WizardRADetailsViewModel);
        }

    }
}
