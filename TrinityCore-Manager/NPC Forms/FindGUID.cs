using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;

namespace TrinityCore_Manager
{
    public partial class FindGUID : Office2007Form
    {
        // https://github.com/TrinityCore/TC-Unused-Guid-Search There you'll find who the original creator made this tool.
        private readonly Dictionary<string, string> _supportedTables = new Dictionary<string, string>
        {
            {"`creature`", "`guid`"},
            {"`gameobject`", "`guid`"},
            {"`waypoint_scripts`", "`guid`"},
            {"`pool_template`", "`entry`"},
            {"`game_event`", "`eventEntry`"},
            {"`creature_equip_template`", "`entry`"},
            {"`trinity_string`", "`entry`"},
        };

        public FindGUID()
        {
            InitializeComponent();

            tableComboBox.Items.AddRange(_supportedTables.Keys.Cast<object>().ToArray());
            tableComboBox.SelectedIndex = 0;
        }

        private void FindGUID_Load(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            guidListView.Items.Clear();

            var selectedTable = tableComboBox.Text;
            var existingGuids = new List<int>();

            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = Settings.Default.DBHost;
            connectionString.Port = (uint)Settings.Default.DBPort;
            connectionString.UserID = Settings.Default.DBUsername;
            connectionString.Password = Settings.Default.DBPassword.DecryptString(Encoding.Unicode.GetBytes(Settings.Default.Entropy)).ToInsecureString();
            connectionString.Database = Settings.Default.DBWorldName;

            try
            {
                using (var connection = new MySqlConnection(connectionString.ToString()))
                {
                    connection.Open();
                    using (var query = new MySqlCommand(string.Format("SELECT {0} FROM {1}", _supportedTables[selectedTable], selectedTable), connection))
                        using (var reader = query.ExecuteReader())
                            while (reader != null && reader.Read())
                                existingGuids.Add(reader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var possibleGuids = Enumerable.Range(1, existingGuids.Last());
            var missingGuids = possibleGuids.Except(existingGuids);
            IEnumerable<int> selectedMissingGuids = null;

            if (!missingGuids.Any())
                selectedMissingGuids = Enumerable.Range(existingGuids.Last() + 1, (int)guidIntegerInput.Value);
            else if (radioButtonRandom.Checked)
                selectedMissingGuids = missingGuids.Take((int)guidIntegerInput.Value);
            else if (radioBoxConsecutive.Checked)
                selectedMissingGuids = GetConsecutiveGuids(missingGuids.ToArray(), (int)guidIntegerInput.Value) ?? Enumerable.Range(existingGuids.Last() + 1, (int)guidIntegerInput.Value);

            if (selectedMissingGuids != null)
                foreach (var guid in selectedMissingGuids)
                    guidListView.Items.Add(guid.ToString());
        }

        private static IEnumerable<int> GetConsecutiveGuids(IList<int> input, int minimum)
        {
            var count = 1;
            var result = new List<int>();

            for (var i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1] - 1)
                {
                    count++;
                    result.Add(input[i]);
                }
                else
                {
                    result = new List<int>();
                    count = 1;
                }

                if (count > minimum)
                    return result;
            }

            return result.Count < minimum ? null : result;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
