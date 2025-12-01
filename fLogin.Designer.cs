namespace CF
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            PassWord = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            UserName = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 157);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(325, 127);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(227, 127);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(PassWord);
            panel3.Location = new Point(7, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 50);
            panel3.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(126, 10);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(267, 23);
            txbPassWord.TabIndex = 2;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // PassWord
            // 
            PassWord.AutoSize = true;
            PassWord.Location = new Point(24, 13);
            PassWord.Name = "PassWord";
            PassWord.Size = new Size(58, 15);
            PassWord.TabIndex = 1;
            PassWord.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(UserName);
            panel2.Location = new Point(7, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 47);
            panel2.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(126, 11);
            txbUserName.Name = "txbUserName";
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
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(410, 162);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label PassWord;
        private Panel panel2;
        private TextBox txbUserName;
        private Label UserName;
        private Button btnExit;
        private Button btnLogin;
    }
}
