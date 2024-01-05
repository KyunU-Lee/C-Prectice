namespace Lotto_M_S
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aBoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HeaderPanel = new Lotto_M_S.BorderPanel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.chkTbx6 = new Lotto_M_S.ChkTextBox();
            this.chkTbx5 = new Lotto_M_S.ChkTextBox();
            this.chkTbx4 = new Lotto_M_S.ChkTextBox();
            this.chkTbx3 = new Lotto_M_S.ChkTextBox();
            this.chkTbx2 = new Lotto_M_S.ChkTextBox();
            this.chkTbx1 = new Lotto_M_S.ChkTextBox();
            this.Midpanel = new Lotto_M_S.BorderPanel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Footerpanel = new Lotto_M_S.BorderPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.Midpanel.SuspendLayout();
            this.Footerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.aBoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // aBoutToolStripMenuItem
            // 
            this.aBoutToolStripMenuItem.Name = "aBoutToolStripMenuItem";
            this.aBoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aBoutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aBoutToolStripMenuItem.Text = "ABout";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.btnClearAll);
            this.HeaderPanel.Controls.Add(this.btnRun);
            this.HeaderPanel.Controls.Add(this.chkTbx6);
            this.HeaderPanel.Controls.Add(this.chkTbx5);
            this.HeaderPanel.Controls.Add(this.chkTbx4);
            this.HeaderPanel.Controls.Add(this.chkTbx3);
            this.HeaderPanel.Controls.Add(this.chkTbx2);
            this.HeaderPanel.Controls.Add(this.chkTbx1);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 24);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(679, 102);
            this.HeaderPanel.TabIndex = 6;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(583, 39);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(502, 39);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chkTbx6
            // 
            this.chkTbx6.Location = new System.Drawing.Point(421, 11);
            this.chkTbx6.Name = "chkTbx6";
            this.chkTbx6.Size = new System.Drawing.Size(75, 78);
            this.chkTbx6.TabIndex = 5;
            // 
            // chkTbx5
            // 
            this.chkTbx5.Location = new System.Drawing.Point(340, 11);
            this.chkTbx5.Name = "chkTbx5";
            this.chkTbx5.Size = new System.Drawing.Size(75, 78);
            this.chkTbx5.TabIndex = 4;
            // 
            // chkTbx4
            // 
            this.chkTbx4.Location = new System.Drawing.Point(259, 11);
            this.chkTbx4.Name = "chkTbx4";
            this.chkTbx4.Size = new System.Drawing.Size(75, 78);
            this.chkTbx4.TabIndex = 3;
            // 
            // chkTbx3
            // 
            this.chkTbx3.Location = new System.Drawing.Point(178, 11);
            this.chkTbx3.Name = "chkTbx3";
            this.chkTbx3.Size = new System.Drawing.Size(75, 78);
            this.chkTbx3.TabIndex = 2;
            // 
            // chkTbx2
            // 
            this.chkTbx2.Location = new System.Drawing.Point(97, 11);
            this.chkTbx2.Name = "chkTbx2";
            this.chkTbx2.Size = new System.Drawing.Size(75, 78);
            this.chkTbx2.TabIndex = 1;
            // 
            // chkTbx1
            // 
            this.chkTbx1.Location = new System.Drawing.Point(21, 11);
            this.chkTbx1.Name = "chkTbx1";
            this.chkTbx1.Size = new System.Drawing.Size(75, 78);
            this.chkTbx1.TabIndex = 0;
            // 
            // Midpanel
            // 
            this.Midpanel.Controls.Add(this.btnRemoveAll);
            this.Midpanel.Controls.Add(this.btnRemove);
            this.Midpanel.Controls.Add(this.btnAdd);
            this.Midpanel.Controls.Add(this.btnExport);
            this.Midpanel.Controls.Add(this.btnCopy);
            this.Midpanel.Controls.Add(this.lv1);
            this.Midpanel.Location = new System.Drawing.Point(0, 126);
            this.Midpanel.Name = "Midpanel";
            this.Midpanel.Size = new System.Drawing.Size(679, 435);
            this.Midpanel.TabIndex = 7;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(417, 5);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(88, 23);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(511, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(592, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(93, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv1.FullRowSelect = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(12, 34);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(655, 395);
            this.lv1.TabIndex = 6;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DateTime";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "2";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "3";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "4";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "5";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "6";
            this.columnHeader7.Width = 83;
            // 
            // Footerpanel
            // 
            this.Footerpanel.Controls.Add(this.label1);
            this.Footerpanel.Controls.Add(this.btnExit);
            this.Footerpanel.Controls.Add(this.lbl1);
            this.Footerpanel.Location = new System.Drawing.Point(0, 561);
            this.Footerpanel.Name = "Footerpanel";
            this.Footerpanel.Size = new System.Drawing.Size(679, 63);
            this.Footerpanel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(12, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(148, 27);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "DateTime :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 624);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.Midpanel);
            this.Controls.Add(this.Footerpanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.Midpanel.ResumeLayout(false);
            this.Footerpanel.ResumeLayout(false);
            this.Footerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aBoutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private BorderPanel HeaderPanel;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRun;
        private ChkTextBox chkTbx6;
        private ChkTextBox chkTbx5;
        private ChkTextBox chkTbx4;
        private ChkTextBox chkTbx3;
        private ChkTextBox chkTbx2;
        private ChkTextBox chkTbx1;
        private BorderPanel Midpanel;
        private BorderPanel Footerpanel;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl1;
    }
}

