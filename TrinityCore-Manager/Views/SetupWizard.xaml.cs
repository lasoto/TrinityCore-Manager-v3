using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ookii.Dialogs.Wpf;

namespace TrinityCore_Manager.Views
{
    /// <summary>
    /// Interaction logic for SetupWizard.xaml
    /// </summary>
    public partial class SetupWizard : Window
    {
        public SetupWizard()
        {
            InitializeComponent();
        }

        private void browseServerFolder_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new VistaFolderBrowserDialog();

            var showDialog = dialog.ShowDialog();

            if (showDialog.HasValue && showDialog.Value)
            {
            NoDebugOrReleaseFolder:
                if (!(dialog.SelectedPath.IndexOf("debug", StringComparison.OrdinalIgnoreCase) >= 0 || dialog.SelectedPath.IndexOf("release", StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    MessageBoxResult result = MessageBox.Show("The selected folder should contain the authserver.exe and worldserver.exe executables and are most of the time placed inside the 'debug' or 'release' folder. Do you still wish to continue?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result != MessageBoxResult.Yes)
                    {
                        var showDialog2 = dialog.ShowDialog();

                        if (showDialog2.HasValue && showDialog2.Value)
                            goto NoDebugOrReleaseFolder;

                        return;
                    }
                }

                ServerFolderTextBox.SetValue(TextBox.TextProperty, dialog.SelectedPath);
            }
        }
    }
}
