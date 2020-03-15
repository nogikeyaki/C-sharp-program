namespace System_Model_20200315.Form_Dir
{
    partial class Login_Fm
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
            this.UserNo = new System.Windows.Forms.TextBox();
            this.Version = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNo
            // 
            this.UserNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UserNo.Location = new System.Drawing.Point(99, 52);
            this.UserNo.Margin = new System.Windows.Forms.Padding(4);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(101, 25);
            this.UserNo.TabIndex = 64;
            // 
            // Version
            // 
            this.Version.Location = new System.Drawing.Point(99, 192);
            this.Version.Margin = new System.Windows.Forms.Padding(4);
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Size = new System.Drawing.Size(101, 25);
            this.Version.TabIndex = 68;
            this.Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(99, 141);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 38);
            this.btnLogin.TabIndex = 66;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "版本";
            // 
            // PassWord
            // 
            this.PassWord.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PassWord.Location = new System.Drawing.Point(99, 93);
            this.PassWord.Margin = new System.Windows.Forms.Padding(4);
            this.PassWord.MaxLength = 20;
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(101, 25);
            this.PassWord.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "密碼";
            // 
            // Login_Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 273);
            this.Controls.Add(this.UserNo);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNo;
        private System.Windows.Forms.TextBox Version;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}