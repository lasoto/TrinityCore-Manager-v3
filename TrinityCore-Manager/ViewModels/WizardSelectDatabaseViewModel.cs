using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Models;

namespace TrinityCore_Manager.ViewModels
{
    public class WizardSelectDatabaseViewModel : ViewModelBase
    {

        public Command OkCommand { get; private set; }

        public Command CancelCommand { get; private set; }

        public WizardSelectDatabaseViewModel(WizardSelectDatabaseModel model, string host, int port, string username, string password)
        {

            WizardSelectDatabase = model;

            OkCommand = new Command(Ok);
            CancelCommand = new Command(CancelCmd);

            var connStr = new MySqlConnectionStringBuilder();
            connStr.Server = host;
            connStr.Port = (uint)port;
            connStr.UserID = username;
            connStr.Password = password;

            using (var connection = new MySqlConnection(connStr.ToString()))
            {
                connection.Open();

                using (var returnVal = new MySqlDataAdapter("SHOW DATABASES", connection))
                {

                    var dataTable = new DataTable();
                    returnVal.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                        for (int i = 0; i < row.ItemArray.Length; i++)
                            Databases.Add(row.ItemArray[i].ToString());

                }

            }

        }

        private void Ok()
        {
            this.SaveAndCloseViewModel();
        }

        private void CancelCmd()
        {
            this.CancelAndCloseViewModel();
        }

        [Model]
        public WizardSelectDatabaseModel WizardSelectDatabase
        {
            get
            {
                return GetValue<WizardSelectDatabaseModel>(WizardSelectDatabaseProperty);
            }
            set
            {
                SetValue(WizardSelectDatabaseProperty, value);
            }
        }

        public static readonly PropertyData WizardSelectDatabaseProperty = RegisterProperty("WizardSelectDatabase", typeof(WizardSelectDatabaseModel));

        [ViewModelToModel("WizardSelectDatabase")]
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

        [ViewModelToModel("WizardSelectDatabase")]
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
