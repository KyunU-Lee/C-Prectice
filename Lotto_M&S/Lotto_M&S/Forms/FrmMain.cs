using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace Lotto_M_S
{
    public partial class FrmMain : Form
    {
        RandomCreator _rnd = new RandomCreator();

        List<ChkTextBox> _chktbxControlList = new List<ChkTextBox>();
        List<int> _randomNumberlist = new List<int>();
        public FrmMain()
        {
            InitializeComponent();
            _chktbxControlList.Add(chkTbx1);
            _chktbxControlList.Add(chkTbx2);
            _chktbxControlList.Add(chkTbx3);
            _chktbxControlList.Add(chkTbx4);
            _chktbxControlList.Add(chkTbx5);
            _chktbxControlList.Add(chkTbx6);

            timer1.Start();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            _randomNumberlist.Clear();
            foreach (ChkTextBox usr in _chktbxControlList)
                usr.GetFixedNumber(_randomNumberlist);

            _randomNumberlist = _rnd.getRandomNumber(_randomNumberlist);

            for(int i  = 0; i < _randomNumberlist.Count; i++)
                _chktbxControlList[i].setRandomNumber(_randomNumberlist[i]);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            _randomNumberlist.Clear();
            foreach (ChkTextBox usr in _chktbxControlList)
            {
                usr.MakeCheckBoxFalse();
                usr.ClearValue();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lv1.Items)
            {
                lv1.Items.Remove(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count != 0)
            {
                int selectRow = lv1.SelectedItems[0].Index;
                lv1.Items.RemoveAt(selectRow);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_randomNumberlist.Count == 0)
                return;

            _randomNumberlist.Sort();

            ListViewItem newItem = new ListViewItem(DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss"));
            foreach (int i in _randomNumberlist)
                newItem.SubItems.Add(i.ToString());
            //리스트에 item 이 존재할 때 중복체크
            bool sameChecker = true;
            if (lv1.Items.Count > 0)
            {
                //바로 앞아이 템과 중복을 비교해야함 
                for (int innerIndex = 1; innerIndex < 7; innerIndex++)
                    if (lv1.Items[lv1.Items.Count-1].SubItems[innerIndex].Text != newItem.SubItems[innerIndex].Text)
                        sameChecker = false;
                
                if (sameChecker) 
                {
                    MessageBox.Show("Same Number");
                    return;
                }
                else
                    lv1.Items.Add(newItem);
            }
            // 리스트에 item 이 없을 때 그냥 append
            else
                lv1.Items.Add(newItem);

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm();
            exitForm.ShowDialog();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            HeaderPanel.BorderStyle = BorderStyle.None;

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255,0, 0, 0), 2), HeaderPanel.ClientRectangle);
        }

        private void Midpanel_Paint(object sender, PaintEventArgs e)
        {
            Midpanel.BorderStyle = BorderStyle.None;

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0), 2), Midpanel.ClientRectangle);
        }

        private void Footerpanel_Paint(object sender, PaintEventArgs e)
        {
            Footerpanel.BorderStyle = BorderStyle.None;

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0), 2), Footerpanel.ClientRectangle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 

            foreach(var item in lv1.SelectedItems)
            {
                ListViewItem lvi = item as ListViewItem;
                if(lvi != null)
                {
                    foreach(ListViewItem.ListViewSubItem sub in lvi.SubItems)
                    {
                        sb.Append(sub.Text + "\t");
                    }
                }
                sb.AppendLine();
            }
            Clipboard.SetDataObject(sb.ToString().Trim());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("SaveLotto.csv"))
            {

                StringBuilder sb = new StringBuilder();

                foreach (var item in lv1.Items)
                {
                    ListViewItem lvi = item as ListViewItem;
                    if (lvi != null)
                    {
                        foreach (ListViewItem.ListViewSubItem sub in lvi.SubItems)
                        {
                            sb.Append(sub.Text + "\t");
                        }
                    }
                    sb.AppendLine();
                }

                tw.Write(sb.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
