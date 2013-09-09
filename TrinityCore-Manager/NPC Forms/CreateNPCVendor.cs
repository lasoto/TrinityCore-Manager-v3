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

namespace TrinityCore_Manager.NPC_Forms
{
    public partial class CreateNPCVendor : Office2007Form
    {
        public CreateNPCVendor()
        {
            InitializeComponent();
        }

        // Once the users inputs all the desired info in the fields, he clicks Plus (add) button and the button will send that data to the ListView beneath.
        // Refresh button should refresh the ListView control in case user changes any value and update the ListView with only changed values.
        // Remove button should remove the selected row from the ListView.
        // If the user clicks on any row from the ListView, than the row selected should send those values to the controls in the form. 
        // e.g. if the Entry in the ListView shows 33534 then npcEntryIntegerInput should show that as well and so on.

        private void findNpcButton_Click(object sender, EventArgs e)
        {
            using (FindNPC fn = new FindNPC())
            {
                if (fn.ShowDialog() == DialogResult.OK)
                {
                    // FindNPC form uses ListView to list all of the NPC's that are in `creature` table. When FindNPC form loads, it should load all of the NPCs currently in that table.
                    // ListView uses 2 columns (NPC ID, NPC NAME). So once user clicks on a desired NPC from the list, this dialog here should return that value to the npcEntryIntegerInput
                }
            }
        }

        private void findItemButton_Click(object sender, EventArgs e)
        {
            using (FindItem fi = new FindItem())
            {
                if (fi.ShowDialog() == DialogResult.OK)
                {
                    // FindItem form uses ListView to list all of the NPC's that are in `item_template` table. When FindItem form loads, it should load all of the item's currently in that table.
                    // ListView uses 2 columns (Item ID, Item NAME). So once user clicks on a desired Item from the list, this dialog here should return that value to the itemEntryIntegerInput
                }
            }
        }

        private void showCodeButton_Click(object sender, EventArgs e)
        {
            // If control fields = !empty then this form should load appropirate SQL code for it, in case user wants to see what the code looks like.
            // Also, bear in mind that this is the ListView we are working with so the code has to adapt dynamically to the changes.
            // Meaning if the user only added 1 row to the ListView then code should only show 1 value insertion and end the code with ';'
            // Whereas if the user added multiple rows to the ListView then each row should end with a ',' and repeat the insertion value NOT the whole statement.

            /*
             * 
             * e.g. User added 3 rows to the ListView
             * 
             * DELETE FROM `npc_vendor` WHERE `entry` = @entry;
             * INSERT INTO `npc_vendor` (`entry`, `slot`, `item`, `maxcount`, `incrtime`, `ExtendedCost`) VALUES
             * (@entry, @slot, @item, @maxcount, @incrtime, @ExtendedCost),
             * (@entry, @slot, @item, @maxcount, @incrtime, @ExtendedCost),
             * (@entry, @slot, @item, @maxcount, @incrtime, @ExtendedCost);
             * 
             * 
             */

            using (ShowSQLCode sqc = new ShowSQLCode())
                sqc.ShowDialog();
        }
    }
}
