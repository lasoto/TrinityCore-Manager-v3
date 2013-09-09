using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TrinityCore_Manager
{
    public partial class SearchDatabaseForm : Form
    {
        private Databases database;
        private List<string> databasesToList = new List<string>();

        public SearchDatabaseForm(Databases database, List<string> databasesToList)
        {
            InitializeComponent();

            this.database = database;
            this.databasesToList = databasesToList;
        }

        private void SearchDatabaseForm_Load(object sender, EventArgs e)
        {
            listViewXDatabases.Columns.Add("Database", 210, HorizontalAlignment.Left);

            for (int i = 0; i < databasesToList.Count; ++i)
            {
                ListViewItem itemAdded = listViewXDatabases.Items.Add(databasesToList[i]);

                //! Select the currently used database (if any)
                //? Why the heck doesn't this work?!
                switch (database)
                {
                    case Databases.DbAuth:
                        if (((SetupWizard)Owner).authDBTextBox.Text == databasesToList[i])
                            itemAdded.Selected = true;
                        break;
                    case Databases.DbCharacters:
                        if (((SetupWizard)Owner).charactersDBTextBox.Text == databasesToList[i])
                            itemAdded.Selected = true;
                        break;
                    case Databases.DbWorld:
                        if (((SetupWizard)Owner).worldDBTextBox.Text == databasesToList[i])
                            itemAdded.Selected = true;
                        break;
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            switch (database)
            {
                case Databases.DbAuth:
                    ((SetupWizard)Owner).authDBTextBox.Text = listViewXDatabases.SelectedItems[0].Text;
                    break;
                case Databases.DbCharacters:
                    ((SetupWizard)Owner).charactersDBTextBox.Text = listViewXDatabases.SelectedItems[0].Text;
                    break;
                case Databases.DbWorld:
                    ((SetupWizard)Owner).worldDBTextBox.Text = listViewXDatabases.SelectedItems[0].Text;
                    break;
            }

            Close();
        }

        private void listViewXDatabases_DoubleClick(object sender, EventArgs e)
        {
            buttonX1_Click(sender, e);
        }

        private void listViewXDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonX1.Enabled = listViewXDatabases.SelectedItems.Count > 0;
        }

        private void SearchDatabaseForm_KeyDown(object sender, KeyEventArgs e)
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
