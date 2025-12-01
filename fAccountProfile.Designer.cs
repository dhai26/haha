namespace CF
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbUserName = new TextBox();
            UserName = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            txbNewPassword = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            txbRePassWord = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(UserName);
            panel2.Location = new Point(8, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 47);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(126, 11);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(267, 23);
            txbUserName.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(15, 14);
            UserName.Name = "UserName";
            UserName.Size = new Size(79, 15);
            UserName.TabIndex = 0;
            UserName.Text = "Tên Tài Khoản";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 47);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(126, 11);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(267, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên Hiển Thị";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(8, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 47);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(126, 11);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(267, 23);
            txbPassWord.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 14);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPassword);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(8, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 47);
            panel4.TabIndex = 4;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(126, 11);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(267, 23);
            txbNewPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Mật Khẩu Mới";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(txbRePassWord);
            panel5.Location = new Point(8, 224);
            panel5.Name = "panel5";
            panel5.Size = new Size(396, 47);
            panel5.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 1;
            // 
            // txbRePassWord
            // 
            txbRePassWord.AutoSize = true;
            txbRePassWord.Location = new Point(15, 14);
            txbRePassWord.Name = "txbRePassWord";
            txbRePassWord.Size = new Size(75, 15);
            txbRePassWord.TabIndex = 0;
            txbRePassWord.Text = "Nhập Lại MK";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(248, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 39);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(329, 277);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 39);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(416, 328);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
//            Load += fAccountProfile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUserName;
        private Label UserName;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label1;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label2;
        private Panel panel4;
        private TextBox txbNewPassword;
        private Label label3;
        private Panel panel5;
        private TextBox textBox1;
        private Label txbRePassWord;
        private Button btnUpdate;
        private Button btnExit;
    }
}