using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace TrinityCore_Manager.Models
{
    public class WizardSelectDatabaseModel : ModelBase
    {

        public WizardSelectDatabaseModel()
        {
            Databases = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Databases
        {
            get
            {
                return GetValue<ObservableCollection<string>>(DatabasesProperty);
            }
            set
            {
                SetValue(DatabasesProperty, value);
            }
        }

        public static readonly PropertyData DatabasesProperty = RegisterProperty("Databases", typeof(ObservableCollection<string>));

        public string SelectedDatabaseName
        {
            get
            {
                return GetValue<string>(SelectedDatabaseNameProperty);
            }
            set
            {
                SetValue(SelectedDatabaseNameProperty, value);
            }
        }

        public static readonly PropertyData SelectedDatabaseNameProperty = RegisterProperty("SelectedDatabaseName", typeof(string));

    }
}
