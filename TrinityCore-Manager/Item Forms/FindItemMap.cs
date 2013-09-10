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
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.CustomForms;
using BrightIdeasSoftware;

namespace TrinityCore_Manager
{
    public partial class FindItemMap : TCMForm
    {

        public int IdSelected
        {
            get
            {
                if (findMapListView.SelectedItem != null)
                    return ((SerializedItem)findMapListView.SelectedItem.RowObject).Id;
                else
                    return 0;
            }
        }

        private int _id;

        private static readonly string Directory = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "xml");

        public FindItemMap()
        {

            _id = -1;

            InitializeComponent();

        }


        public FindItemMap(int id)
        {

            _id = id;

            InitializeComponent();

        }


        private async void FindItemMap_Load(object sender, EventArgs e)
        {

            findMapListView.UseFiltering = true;

            StartLoading();

            await Task.Run(() =>
            {

                StreamReader reader = new StreamReader(Path.Combine(Directory, "Map.xml"));

                XmlSerializer serializer = new XmlSerializer(typeof(List<SerializedItem>));
                List<SerializedItem> _items = (List<SerializedItem>)serializer.Deserialize(reader);

                reader.Close();

                Invoke((MethodInvoker)delegate
                {
                    findMapListView.SetObjects(_items);
                });

                if (_id != -1 && _items.Any(p => p.Id == _id))
                {
                    Invoke((MethodInvoker)delegate
                    {
                        findMapListView.SelectObject(_items.SingleOrDefault(p => p.Id == _id), true);
                    });
                }

            });

            StopLoading();

        }

        private void itemFindDisplayIdTextBox_TextChanged(object sender, EventArgs e)
        {
            findMapListView.ModelFilter = new ModelFilter(delegate(object x)
            {
                return ((SerializedItem)x).Name.ToLower().Contains(itemFindDisplayIdTextBox.Text.ToLower());
            });
        }

        private void FindItemMap_KeyDown(object sender, KeyEventArgs e)
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
