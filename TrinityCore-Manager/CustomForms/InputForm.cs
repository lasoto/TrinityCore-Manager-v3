using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace TrinityCore_Manager.CustomForms
{

    public partial class InputForm : TCMForm
    {

        private string[] _inputs;

        public InputForm(string title, string[] inputs)
        {

            _inputs = inputs;

            InitializeComponent();

            this.TitleText = title;

        }

        private void InputForm_Load(object sender, EventArgs e)
        {

            int len = _inputs.Length;

            int xi = 100;
            int yi = 35;
            for (int i = 0; i < len; i++)
            {

                var txtBox = new TextBoxX();
                txtBox.Name = "textbox_" + i;
                txtBox.Location = new Point(xi, yi);
                txtBox.Width = 180;

                this.Controls.Add(txtBox);

                yi += 25;

            }

            this.Size = new Size(xi + 30, yi + 30);

        }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
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
