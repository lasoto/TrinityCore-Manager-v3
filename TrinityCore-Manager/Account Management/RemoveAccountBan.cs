using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.CustomForms;

namespace TrinityCore_Manager
{
    public partial class RemoveAccountBan : TCMForm
    {
        public RemoveAccountBan()
        {
            InitializeComponent();
        }

        private async void RemoveAccountBan_Load(object sender, EventArgs e)
        {

            StartLoading();

            List<BannedAccount> accounts = await TCManager.Instance.AuthDatabase.GetBannedAccounts();

            foreach (BannedAccount account in accounts)
            {

                Account acct = await TCManager.Instance.AuthDatabase.GetAccount(account.Id);

                if (acct != null)
                    accountListComboBox.Items.Add(acct.Username);

            }

            StopLoading();

        }
    }
}
