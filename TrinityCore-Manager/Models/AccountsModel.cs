using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace TrinityCore_Manager.Models
{
    [Serializable]
    public class AccountsModel : ModelBase
    {

        public AccountsModel()
        {
            TheAccounts = new ObservableCollection<AccountModel>();
        }

        protected AccountsModel(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        public ObservableCollection<AccountModel> TheAccounts
        {
            get
            {
                return GetValue<ObservableCollection<AccountModel>>(TheAccountsProperty);
            }
            set
            {
                SetValue(TheAccountsProperty, value);
            }
        }

        public static readonly PropertyData TheAccountsProperty = RegisterProperty("TheAccounts", typeof(ObservableCollection<AccountModel>));

    }
}
