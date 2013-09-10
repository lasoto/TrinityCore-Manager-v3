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
using TrinityCore_Manager.CustomForms;
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.Database.Enums;
using TrinityCore_Manager.Extensions;

namespace TrinityCore_Manager
{
    public partial class PlayerInformation : TCMForm
    {

        private string _charName;

        public PlayerInformation(string charName)
        {

            _charName = charName;

            InitializeComponent();

        }

        private async void PlayerInformation_Load(object sender, EventArgs e)
        {

            StartLoading();

            int guid = await TCManager.Instance.CharDatabase.GetCharacterGuid(_charName);

            TCCharacter character = await TCManager.Instance.CharDatabase.GetCharacter(guid);

            if (character == null)
            {

                MessageBoxEx.Show(this, "Character does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                StopLoading();

                Close();

                return;

            }

            int accountId = character.Account;

            Account account = await TCManager.Instance.AuthDatabase.GetAccount(accountId);

            if (account == null)
            {

                MessageBoxEx.Show(this, "Account does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                StopLoading();

                Close();

                return;

            }

            nameLabel.Text = character.Name;
            lastLoginLabel.Text = account.LastLogin.ToString();
            lastIpLabel.Text = account.LastIp;
            emailLabel.Text = account.Email;
            raceLabel.Text = character.Race.GetCharacterRaceName();
            classLabel.Text = character.Class.GetCharacterClassName();

            int gold = character.Money / 10000;
            int silver = (character.Money % 10000) / 100;
            int copper = (character.Money % 10000) % 100;

            Console.WriteLine(character.Money);

            moneyLabel.Text = String.Format("{0} Gold {1} Silver {2} Copper", gold, silver, copper);
            totalKillsLabel.Text = character.TotalKills.ToString();
            accountLabel.Text = account.Username;
            accountIdLabel.Text = account.Id.ToString();


            GMLevel level = await TCManager.Instance.AuthDatabase.GetAccountAccess(account.Id);

            switch (level)
            {

                case GMLevel.Player:

                    gmLevelLabel.Text = "Player";

                    break;

                case GMLevel.Moderator:

                    gmLevelLabel.Text = "Moderator";

                    break;

                case GMLevel.GM:

                    gmLevelLabel.Text = "Game Master";

                    break;

                case GMLevel.HeadGM:

                    gmLevelLabel.Text = "Head Game Master";

                    break;

                case GMLevel.Admin:

                    gmLevelLabel.Text = "Administrator";

                    break;

            }

            TimeSpan timePlayed = TimeSpan.FromSeconds(character.TotalTime);

            playedTimeLabel.Text = timePlayed.ToReadableString();
            levelLabel.Text = character.Level.ToString();
            arenaPointsLabel.Text = character.ArenaPoints.ToString();
            honorPointsLabel.Text = character.TotalHonorsPoints.ToString();

            StopLoading();

        }

        private void PlayerInformation_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

    }
}
