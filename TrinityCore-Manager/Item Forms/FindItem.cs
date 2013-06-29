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
    public partial class FindItem : DevComponents.DotNetBar.Office2007Form
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

                return item.ItemImage;

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

                    searchedItems.Add(new SearchedItem() { ItemImage = itemIcon, ItemId = wowItem.ItemId, ItemName = item.Value });

                }
                catch (Exception)
                {
                    searchedItems.Add(new SearchedItem() { ItemImage = WoWItem.UnknownImage, ItemId = item.Key, ItemName = item.Value });
                }

            }

            findItemListView.SetObjects(searchedItems);

            loadingProgress.IsRunning = false;
            loadingProgress.Visible = false;

        }

        class SearchedItem
        {

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

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
