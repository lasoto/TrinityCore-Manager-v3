using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using TrinityCore_Manager.Models;

namespace TrinityCore_Manager.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {

        public Command OkCommand { get; private set; }

        public Command CancelCommand { get; private set; }

        public SettingsViewModel(SettingsModel model)
        {

            Settings = model;

            OkCommand = new Command(ExecuteOk);
            CancelCommand = new Command(ExecuteCancel);
        }

        private void ExecuteOk()
        {
            Properties.Settings.Default.ColorTheme = Convert.ToInt32(SelectedTheme);
            Properties.Settings.Default.Save();
            SaveAndCloseViewModel();
        }

        private void ExecuteCancel()
        {
            CancelAndCloseViewModel();
        }

        [Model]
        public SettingsModel Settings
        {
            get
            {
                return GetValue<SettingsModel>(SettingsProperty);
            }
            set
            {
                SetValue(SettingsProperty, value);
            }
        }

        public static PropertyData SettingsProperty = RegisterProperty("Settings", typeof(SettingsModel));


        [ViewModelToModel("Settings")]
        public ObservableCollection<string> Themes
        {
            get
            {
                return GetValue<ObservableCollection<string>>(ThemesProperty);
            }
            set
            {
                SetValue(ThemesProperty, value);
            }
        }

        public static readonly PropertyData ThemesProperty = RegisterProperty("Themes", typeof(ObservableCollection<string>));

        [ViewModelToModel("Settings")]
        public string SelectedTheme
        {
            get
            {
                return GetValue<string>(SelectedThemeProperty);
            }
            set
            {
                SetValue(SelectedThemeProperty, value);
            }
        }

        public static readonly PropertyData SelectedThemeProperty = RegisterProperty("SelectedTheme", typeof(string), "silver");

    }
}
