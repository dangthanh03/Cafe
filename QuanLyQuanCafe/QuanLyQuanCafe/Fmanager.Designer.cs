namespace QuanLyQuanCafe
{
    partial class Fmanager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCAte = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.BillLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SwtchCb = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónCtlrFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Controls.Add(this.cbCAte);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(488, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số lượng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(135, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 27);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(0, 34);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(129, 28);
            this.cbFood.TabIndex = 2;
            // 
            // cbCAte
            // 
            this.cbCAte.FormattingEnabled = true;
            this.cbCAte.Location = new System.Drawing.Point(0, 0);
            this.cbCAte.Name = "cbCAte";
            this.cbCAte.Size = new System.Drawing.Size(129, 28);
            this.cbCAte.TabIndex = 1;
            this.cbCAte.SelectedIndexChanged += new System.EventHandler(this.cbCAte_SelectedIndexChanged);
            this.cbCAte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCAte_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.BillLv);
            this.panel3.Location = new System.Drawing.Point(488, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 258);
            this.panel3.TabIndex = 2;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(0, 231);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(304, 27);
            this.txbTotalPrice.TabIndex = 1;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BillLv
            // 
            this.BillLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.BillLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.BillLv.Location = new System.Drawing.Point(0, 0);
            this.BillLv.Name = "BillLv";
            this.BillLv.Size = new System.Drawing.Size(304, 225);
            this.BillLv.TabIndex = 0;
            this.BillLv.UseCompatibleStateImageBehavior = false;
            this.BillLv.View = System.Windows.Forms.View.Details;
            this.BillLv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Food";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.numericUpDown2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(488, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 62);
            this.panel4.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(97, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Giảm giá";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(97, 34);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 27);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Chuyển bàn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Flowpanel
            // 
            this.Flowpanel.AutoScroll = true;
            this.Flowpanel.Location = new System.Drawing.Point(12, 31);
            this.Flowpanel.Name = "Flowpanel";
            this.Flowpanel.Size = new System.Drawing.Size(470, 407);
            this.Flowpanel.TabIndex = 3;
            this.Flowpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // SwtchCb
            // 
            this.SwtchCb.FormattingEnabled = true;
            this.SwtchCb.Location = new System.Drawing.Point(488, 410);
            this.SwtchCb.Name = "SwtchCb";
            this.SwtchCb.Size = new System.Drawing.Size(91, 28);
            this.SwtchCb.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMónCtlrFToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMónCtlrFToolStripMenuItem
            // 
            this.thêmMónCtlrFToolStripMenuItem.Name = "thêmMónCtlrFToolStripMenuItem";
            this.thêmMónCtlrFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.thêmMónCtlrFToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.thêmMónCtlrFToolStripMenuItem.Text = "Thêm món      ";
            this.thêmMónCtlrFToolStripMenuItem.Click += new System.EventHandler(this.thêmMónCtlrFToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán      ";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // Fmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SwtchCb);
            this.Controls.Add(this.Flowpanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán Cafe";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ComboBox cbFood;
        private ComboBox cbCAte;
        private Button button1;
        private Panel panel3;
        private ListView BillLv;
        private Panel panel4;
        private FlowLayoutPanel Flowpanel;
        private Button button4;
        private NumericUpDown numericUpDown2;
        private Button button3;
        private Button button2;
        private ComboBox SwtchCb;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txbTotalPrice;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMónCtlrFToolStripMenuItem;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
    }
}