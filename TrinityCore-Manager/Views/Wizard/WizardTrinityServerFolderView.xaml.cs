using System;
using System.Windows.Controls;
using Ookii.Dialogs.Wpf;
using TrinityCore_Manager.ViewModels.Wizard;

namespace TrinityCore_Manager.Views.Wizard
{
    using Catel.Windows.Controls;

    /// <summary>
    /// Interaction logic for TrinityServerFolderWizardView.xaml.
    /// </summary>
    public partial class WizardServerFolderWizardView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrinityServerFolderWizardView"/> class.
        /// </summary>
        public WizardServerFolderWizardView()
        {
            InitializeComponent();
        }

        protected override System.Type GetViewModelType()
        {
            return typeof(WizardTrinityServerFolderViewModel);
        }

        private void browseServerFolder_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            var dialog = new VistaFolderBrowserDialog();

            var showDialog = dialog.ShowDialog();

            if (showDialog.HasValue)
            {

                if (showDialog.Value)
                {
                    ServerFolderTextBox.SetValue(TextBox.TextProperty, dialog.SelectedPath);
                }

            }

        }
    }
}
