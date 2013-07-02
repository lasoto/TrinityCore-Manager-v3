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

namespace TrinityCore_Manager.Item_Forms
{
    public partial class FindItemBagFamily : DevComponents.DotNetBar.Office2007Form
    {

        private int _flags;

        public int Flags
        {
            get
            {
                return _flags;
            }
            set
            {
                int flags = value;

                if ((flags & 0) == 0)
                {
                    noneCheckBox.Checked = true;
                }
                if ((flags & 1) == 1)
                {
                    arrowsCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    bulletsCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    soulShardsCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    leatherworkSuppCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    inscriptionSuppCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    herbsCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    enchantingSuppCheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    engineeringSuppCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    keysCheckBox.Checked = true;
                }
                if ((flags & 512) == 512)
                {
                    gemsCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    miningSuppCheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    soulboundEquipmentCheckBox.Checked = true;
                }
                if ((flags & 4096) == 4096)
                {
                    vanityPetsCheckBox.Checked = true;
                }
                if ((flags & 8192) == 8192)
                {
                    currencyTokensCheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    questItemsCheckBox.Checked = true;
                }
            }
        }

        public FindItemBagFamily()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (noneCheckBox.Checked)
                _flags += 0;
            if (arrowsCheckBox.Checked)
                _flags += 1;
            if (bulletsCheckBox.Checked)
                _flags += 2;
            if (soulShardsCheckBox.Checked)
                _flags += 4;
            if (leatherworkSuppCheckBox.Checked)
                _flags += 8;
            if (inscriptionSuppCheckBox.Checked)
                _flags += 16;
            if (herbsCheckBox.Checked)
                _flags += 32;
            if (enchantingSuppCheckBox.Checked)
                _flags += 64;
            if (engineeringSuppCheckBox.Checked)
                _flags += 128;
            if (keysCheckBox.Checked)
                _flags += 256;
            if (gemsCheckBox.Checked)
                _flags += 512;
            if (miningSuppCheckBox.Checked)
                _flags += 1024;
            if (soulboundEquipmentCheckBox.Checked)
                _flags += 2048;
            if (vanityPetsCheckBox.Checked)
                _flags += 4096;
            if (currencyTokensCheckBox.Checked)
                _flags += 8192;
            if (questItemsCheckBox.Checked)
                _flags += 16384;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            noneCheckBox.Checked = true;
            arrowsCheckBox.Checked = true;
            bulletsCheckBox.Checked = true;
            soulShardsCheckBox.Checked = true;
            leatherworkSuppCheckBox.Checked = true;
            inscriptionSuppCheckBox.Checked = true;
            herbsCheckBox.Checked = true;
            enchantingSuppCheckBox.Checked = true;
            engineeringSuppCheckBox.Checked = true;
            keysCheckBox.Checked = true;
            gemsCheckBox.Checked = true;
            miningSuppCheckBox.Checked = true;
            soulboundEquipmentCheckBox.Checked = true;
            vanityPetsCheckBox.Checked = true;
            currencyTokensCheckBox.Checked = true;
            questItemsCheckBox.Checked = true;
        }
    }
}
