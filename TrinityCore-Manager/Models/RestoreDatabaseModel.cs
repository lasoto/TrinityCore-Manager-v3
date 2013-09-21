using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace TrinityCore_Manager.Models
{
    public class RestoreDatabaseModel : ModelBase
    {

        public RestoreDatabaseModel()
        {
            DatabaseFiles = new ObservableCollection<string>();
        }

        public string AuthDatabase
        {
            get
            {
                return GetValue<string>(AuthDatabaseProperty);
            }
            set
            {
                SetValue(AuthDatabaseProperty, value);
            }
        }

        public static readonly PropertyData AuthDatabaseProperty = RegisterProperty("AuthDatabase", typeof(string));

        public string CharDatabase
        {
            get
            {
                return GetValue<string>(CharDatabaseProperty);
            }
            set
            {
                SetValue(CharDatabaseProperty, value);
            }
        }

        public static readonly PropertyData CharDatabaseProperty = RegisterProperty("CharDatabase", typeof(string));

        public string WorldDatabase
        {
            get
            {
                return GetValue<string>(WorldDatabaseProperty);
            }
            set
            {
                SetValue(WorldDatabaseProperty, value);
            }
        }

        public static readonly PropertyData WorldDatabaseProperty = RegisterProperty("WorldDatabase", typeof(string));

        public string SelectedDatabase
        {
            get
            {
                return GetValue<string>(SelectedDatabaseProperty);
            }
            set
            {
                SetValue(SelectedDatabaseProperty, value);
            }
        }

        public static readonly PropertyData SelectedDatabaseProperty = RegisterProperty("SelectedDatabase", typeof(string));

        public ObservableCollection<string> DatabaseFiles
        {
            get
            {
                return GetValue<ObservableCollection<string>>(DatabaseFilesProperty);
            }
            set
            {
                SetValue(DatabaseFilesProperty, value);
            }
        }

        public static readonly PropertyData DatabaseFilesProperty = RegisterProperty("DatabaseFiles", typeof(ObservableCollection<string>));

    }
}
