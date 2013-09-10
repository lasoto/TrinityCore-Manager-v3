using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class FindItem : Office2007Form
    {

        private int _atPage;

        public FindItem()
        {

            _atPage = 0;

            InitializeComponent();

        }

        private void FindItem_Load(object sender, EventArgs e)
        {
            findItemListView.RowHeight = 56;
            findItemListView.OwnerDraw = true;
            imageColumn.Renderer = new CustomItemRenderer();
            imageColumn.AspectGetter = delegate(object row)
            {

                SearchedItem item = (SearchedItem)row;

                if (item == null)
                    return WoWItem.UnknownImage;

                return item.ItemImage;

            };
            findItemListView.CellToolTipGetter = delegate(OLVColumn col, object row)
            {

                SearchedItem item = (SearchedItem)row;

                var wowItem = item.Item;

                if (wowItem == null)
                    return "";

                string name = (string)wowItem.Data["name"];
                string desc = (string)wowItem.Data["description"];
                string bonding = (string)wowItem.Data["bonding"];
                string invtype = (string)wowItem.Data["inventorytype"];
                string reqLevel = (string)wowItem.Data["requiredLevel"];

                int itemLevel = 0;

                if (wowItem.Data["itemlevel"] != null)
                {
                    itemLevel = (int)wowItem.Data["itemlevel"];
                }
                
                string durability = (string)wowItem.Data["maxdurability"];
                string text = String.Format("Name: {0}\r\nDescription: {1}\r\nBonding: {2}\r\nInventory Type: {3}\r\nRequired Level: {4}\r\nItem Level: {5}\r\nMax Durability: {6}", name, desc == String.Empty ? "None" : desc, bonding, invtype, reqLevel, itemLevel, durability);

                return text;

            };
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {

            _atPage = 0;

            await StartSearch(_atPage);

        }

        private async Task StartSearch(int page)
        {

            if (_atPage < 0)
                return;

            loadingProgress.Visible = true;
            loadingProgress.IsRunning = true;

            Dictionary<int, string> items = await TCManager.Instance.WorldDatabase.SearchForItem(itemFindDisplayIdTextBox.Text, page);

            findItemListView.Items.Clear();

            List<SearchedItem> searchedItems = new List<SearchedItem>();

            foreach (var item in items)
            {

                try
                {

                    WoWItem wowItem = await WoWItem.GetItem(item.Key);

                    Image itemIcon = await wowItem.GetIconTaskAsync();

                    searchedItems.Add(new SearchedItem() { Item = wowItem, ItemImage = itemIcon, ItemId = wowItem.ItemId, ItemName = item.Value });

                }
                catch (Exception)
                {
                    searchedItems.Add(new SearchedItem() { Item = null, ItemImage = WoWItem.UnknownImage, ItemId = item.Key, ItemName = item.Value });
                }

            }

            findItemListView.SetObjects(searchedItems);

            loadingProgress.IsRunning = false;
            loadingProgress.Visible = false;

        }

        class SearchedItem
        {

            public WoWItem Item { get; set; }
            public Image ItemImage { get; set; }
            public int ItemId { get; set; }
            public string ItemName { get; set; }

        }

        class CustomItemRenderer : BaseRenderer
        {

            public override void Render(Graphics g, Rectangle r)
            {

                g.Clear(Color.FromArgb(45, 45, 48));

                Image img = (Image)Aspect;

                if (img == null)
                    return;

                g.DrawImage(img, new Rectangle(r.X, r.Y, 56, 56));

            }

        }

        private void itemFindDisplayIdTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private async void nextButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(itemFindDisplayIdTextBox.Text))
            {

                MessageBoxEx.Show(this, "You must first enter in a search query!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await StartSearch(++_atPage);
        
        }

        private async void prevPageButton_Click(object sender, EventArgs e)
        {

            if (_atPage == 0)
                return;

            await StartSearch(--_atPage);

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;

            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindItem_KeyDown(object sender, KeyEventArgs e)
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
