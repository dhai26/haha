namespace CF
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thongTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            thongTinCaNhanToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel3 = new Panel();
            listBox1 = new ListBox();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            comboBox1 = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thongTinTaiKhoanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(750, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thongTinTaiKhoanToolStripMenuItem
            // 
            thongTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thongTinCaNhanToolStripMenuItem, dangXuatToolStripMenuItem });
            thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
            thongTinTaiKhoanToolStripMenuItem.Size = new Size(122, 20);
            thongTinTaiKhoanToolStripMenuItem.Text = "Thong tin tai khoan";
            // 
            // thongTinCaNhanToolStripMenuItem
            // 
            thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
            thongTinCaNhanToolStripMenuItem.Size = new Size(170, 22);
            thongTinCaNhanToolStripMenuItem.Text = "Thong tin ca nhan";
            thongTinCaNhanToolStripMenuItem.Click += thongTinCaNhanToolStripMenuItem_Click;
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(170, 22);
            dangXuatToolStripMenuItem.Text = "Dang xuat";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbSwitchTable);
            panel2.Controls.Add(btnSwitchTable);
            panel2.Controls.Add(nmDiscount);
            panel2.Controls.Add(btnDiscount);
            panel2.Controls.Add(btnCheckOut);
            panel2.Location = new Point(414, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 63);
            panel2.TabIndex = 2;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 31);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(100, 23);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(3, 2);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(100, 31);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển Bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(133, 32);
            nmDiscount.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(100, 23);
            nmDiscount.TabIndex = 4;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(133, 0);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(100, 33);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm Giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(239, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(90, 48);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh Toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(413, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 213);
            panel3.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, -4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 214);
            listBox1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(413, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 61);
            panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(294, 20);
            nmFoodCount.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(35, 23);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(198, 9);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(90, 40);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm Món";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 23);
            comboBox1.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(192, 23);
            cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(10, 27);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(400, 350);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 377);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán cafe";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
        private ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListBox listBox1;
        private Panel panel4;
        private ComboBox cbCategory;
        private Button btnAddFood;
        private ComboBox comboBox1;
        private NumericUpDown nmFoodCount;
        private Button btnDiscount;
        private Button btnCheckOut;
        private FlowLayoutPanel flpTable;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDiscount;
    }
}