using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.Models;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.ViewModels
{
    public class AccountsViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IMessageService _messageService;

        public Command SearchForAccountCommand { get; private set; }

        public AccountsViewModel(IUIVisualizerService uiVisualizerService, IMessageService messageService)
        {

            _uiVisualizerService = uiVisualizerService;
            _messageService = messageService;

            SearchForAccountCommand = new Command(SearchForAccount);

            TheAccounts = new ObservableCollection<AccountModel>();

        }

        private async void SearchForAccount()
        {

            TheAccounts.Clear();

            var db = TCManager.Instance.AuthDatabase;

            var accts = await db.SearchForAccount("admin");

            foreach (var acct in accts)
            {
                TheAccounts.Add(new AccountModel(acct.Username));
            }

        }

        //[Model]
        //public AccountsModel Accounts
        //{
        //    get
        //    {
        //        return GetValue<AccountsModel>(AccountsProperty);
        //    }
        //    set
        //    {
        //        SetValue("AccountsModel", value);
        //    }
        //}

        //public static readonly PropertyData AccountsProperty = RegisterProperty("Accounts", typeof(AccountsModel));


        //[ViewModelToModel("Accounts")]
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
