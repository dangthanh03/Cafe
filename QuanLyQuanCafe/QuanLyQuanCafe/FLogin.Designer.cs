namespace QuanLyQuanCafe
{
    partial class FLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButt = new System.Windows.Forms.Button();
            this.LogButt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogPass = new System.Windows.Forms.Label();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginText = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButt);
            this.panel1.Controls.Add(this.LogButt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 180);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExitButt
            // 
            this.ExitButt.Location = new System.Drawing.Point(682, 151);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(94, 29);
            this.ExitButt.TabIndex = 4;
            this.ExitButt.Text = "Thoát";
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // LogButt
            // 
            this.LogButt.Location = new System.Drawing.Point(352, 151);
            this.LogButt.Name = "LogButt";
            this.LogButt.Size = new System.Drawing.Size(94, 29);
            this.LogButt.TabIndex = 3;
            this.LogButt.Text = "Đăng nhập";
            this.LogButt.UseVisualStyleBackColor = true;
            this.LogButt.Click += new System.EventHandler(this.LogButt_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LogPass);
            this.panel3.Controls.Add(this.PassInput);
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 45);
            this.panel3.TabIndex = 1;
            // 
            // LogPass
            // 
            this.LogPass.AutoSize = true;
            this.LogPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogPass.Location = new System.Drawing.Point(228, 10);
            this.LogPass.Name = "LogPass";
            this.LogPass.Size = new System.Drawing.Size(97, 24);
            this.LogPass.TabIndex = 1;
            this.LogPass.Text = "Mật khẩu";
            this.LogPass.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(398, 7);
            this.PassInput.Name = "PassInput";
            this.PassInput.PasswordChar = '*';
            this.PassInput.Size = new System.Drawing.Size(181, 27);
            this.PassInput.TabIndex = 2;
            this.PassInput.Text = "1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoginText);
            this.panel2.Controls.Add(this.NameInput);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 45);
            this.panel2.TabIndex = 0;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginText.Location = new System.Drawing.Point(202, 10);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(152, 24);
            this.LoginText.TabIndex = 1;
            this.LoginText.Text = "Tên đăng nhập";
            this.LoginText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(398, 7);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(181, 27);
            this.NameInput.TabIndex = 1;
            this.NameInput.Text = "Thành";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.panel1);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label LoginText;
        private Panel panel2;
        private TextBox NameInput;
        private Panel panel3;
        private Label LogPass;
        private TextBox PassInput;
        private Button ExitButt;
        private Button LogButt;
    }
}