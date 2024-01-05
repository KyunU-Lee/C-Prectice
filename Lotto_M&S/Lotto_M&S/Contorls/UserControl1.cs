using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_M_S
{
    public partial class ChkTextBox : UserControl
    {
        public ChkTextBox()
        {
            InitializeComponent();
            this.chk1.Enabled = false;
            this.tbxNum1.TextChanged += TbxRegex;
            this.chk1.CheckedChanged += chk_Changed;
        }

        private void TbxRegex(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxNum1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                tbxNum1.Text = "";
            }

            int value;
            if (int.TryParse(tbxNum1.Text, out value))
            {
                if (value > 0 && value <= 45)
                {
                }
                else
                {
                    MessageBox.Show("Please enter number 0 ~ 45 ");
                    tbxNum1.Text = "";
                }
            }

            if(tbxNum1.Text.Length == 0)
            {
                chk1.Enabled = false;
            }
            else
            {
                chk1.Enabled = true;
            }

        }

        private void chk_Changed(object sender, EventArgs e)
        {
            if(chk1.Checked)
            {
                tbxNum1.Enabled = false;
            }
            else
            {
                tbxNum1.Enabled = true;
            }
        }

        public void ClearValue()
        {
            tbxNum1.Text = "";
        }

        public List<int> GetFixedNumber(List<int> lst)
        {
            if (this.chk1.Checked)
            {
                int value;
                Int32.TryParse(tbxNum1.Text, out value);
                lst.Add(value);
            }
            else
                lst.Add(-1);

            return lst;
        }

        public void setRandomNumber(int value)
        {
            tbxNum1.Text = "";
            tbxNum1.Text = value.ToString();
        }

        public void MakeCheckBoxFalse()
        {
            this.chk1.Checked = false;
        }



    }
}
