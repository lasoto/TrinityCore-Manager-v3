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
