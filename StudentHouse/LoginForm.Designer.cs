namespace StudentHouse
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLoginInfo = new System.Windows.Forms.Panel();
            this.lblLogIn4 = new System.Windows.Forms.Label();
            this.lblLogIn3 = new System.Windows.Forms.Label();
            this.lblLogIn1 = new System.Windows.Forms.Label();
            this.lblLogIn2 = new System.Windows.Forms.Label();
            this.panelLoginInput = new System.Windows.Forms.Panel();
            this.lblUnsuccessfulLogin2 = new System.Windows.Forms.Label();
            this.lblUnsuccessfulLogin1 = new System.Windows.Forms.Label();
            this.lblLogIn6 = new System.Windows.Forms.Label();
            this.lblLogIn5 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLoginInfo.SuspendLayout();
            this.panelLoginInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxName.Location = new System.Drawing.Point(71, 166);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(307, 19);
            this.tbxName.TabIndex = 0;
            this.tbxName.Text = "Username";
            this.tbxName.Enter += new System.EventHandler(this.tbxName_Enter);
            this.tbxName.Leave += new System.EventHandler(this.tbxName_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(291, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelLoginInfo
            // 
            this.panelLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.panelLoginInfo.Controls.Add(this.lblLogIn4);
            this.panelLoginInfo.Controls.Add(this.lblLogIn3);
            this.panelLoginInfo.Controls.Add(this.lblLogIn1);
            this.panelLoginInfo.Controls.Add(this.lblLogIn2);
            this.panelLoginInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginInfo.Location = new System.Drawing.Point(0, 0);
            this.panelLoginInfo.Name = "panelLoginInfo";
            this.panelLoginInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelLoginInfo.Size = new System.Drawing.Size(468, 470);
            this.panelLoginInfo.TabIndex = 5;
            // 
            // lblLogIn4
            // 
            this.lblLogIn4.AutoSize = true;
            this.lblLogIn4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn4.ForeColor = System.Drawing.Color.White;
            this.lblLogIn4.Location = new System.Drawing.Point(43, 298);
            this.lblLogIn4.Name = "lblLogIn4";
            this.lblLogIn4.Size = new System.Drawing.Size(221, 20);
            this.lblLogIn4.TabIndex = 9;
            this.lblLogIn4.Text = "arranging day to day matters";
            // 
            // lblLogIn3
            // 
            this.lblLogIn3.AutoSize = true;
            this.lblLogIn3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn3.ForeColor = System.Drawing.Color.White;
            this.lblLogIn3.Location = new System.Drawing.Point(43, 275);
            this.lblLogIn3.Name = "lblLogIn3";
            this.lblLogIn3.Size = new System.Drawing.Size(261, 20);
            this.lblLogIn3.TabIndex = 8;
            this.lblLogIn3.Text = "Student Housing BV Application for";
            // 
            // lblLogIn1
            // 
            this.lblLogIn1.AutoSize = true;
            this.lblLogIn1.Font = new System.Drawing.Font("Century Gothic", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn1.ForeColor = System.Drawing.Color.White;
            this.lblLogIn1.Location = new System.Drawing.Point(31, 93);
            this.lblLogIn1.Name = "lblLogIn1";
            this.lblLogIn1.Size = new System.Drawing.Size(201, 81);
            this.lblLogIn1.TabIndex = 6;
            this.lblLogIn1.Text = "Hello";
            // 
            // lblLogIn2
            // 
            this.lblLogIn2.AutoSize = true;
            this.lblLogIn2.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblLogIn2.ForeColor = System.Drawing.Color.White;
            this.lblLogIn2.Location = new System.Drawing.Point(31, 159);
            this.lblLogIn2.Name = "lblLogIn2";
            this.lblLogIn2.Size = new System.Drawing.Size(285, 81);
            this.lblLogIn2.TabIndex = 7;
            this.lblLogIn2.Text = "there! :)";
            // 
            // panelLoginInput
            // 
            this.panelLoginInput.Controls.Add(this.lblUnsuccessfulLogin2);
            this.panelLoginInput.Controls.Add(this.lblUnsuccessfulLogin1);
            this.panelLoginInput.Controls.Add(this.lblLogIn6);
            this.panelLoginInput.Controls.Add(this.lblLogIn5);
            this.panelLoginInput.Controls.Add(this.tbxKey);
            this.panelLoginInput.Controls.Add(this.panel3);
            this.panelLoginInput.Controls.Add(this.panel2);
            this.panelLoginInput.Controls.Add(this.tbxName);
            this.panelLoginInput.Controls.Add(this.btnLogin);
            this.panelLoginInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLoginInput.Location = new System.Drawing.Point(465, 0);
            this.panelLoginInput.Name = "panelLoginInput";
            this.panelLoginInput.Size = new System.Drawing.Size(454, 470);
            this.panelLoginInput.TabIndex = 11;
            // 
            // lblUnsuccessfulLogin2
            // 
            this.lblUnsuccessfulLogin2.AutoSize = true;
            this.lblUnsuccessfulLogin2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsuccessfulLogin2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnsuccessfulLogin2.Location = new System.Drawing.Point(58, 299);
            this.lblUnsuccessfulLogin2.Name = "lblUnsuccessfulLogin2";
            this.lblUnsuccessfulLogin2.Size = new System.Drawing.Size(108, 17);
            this.lblUnsuccessfulLogin2.TabIndex = 14;
            this.lblUnsuccessfulLogin2.Text = "Please, try again.";
            // 
            // lblUnsuccessfulLogin1
            // 
            this.lblUnsuccessfulLogin1.AutoSize = true;
            this.lblUnsuccessfulLogin1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsuccessfulLogin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnsuccessfulLogin1.Location = new System.Drawing.Point(58, 282);
            this.lblUnsuccessfulLogin1.Name = "lblUnsuccessfulLogin1";
            this.lblUnsuccessfulLogin1.Size = new System.Drawing.Size(120, 17);
            this.lblUnsuccessfulLogin1.TabIndex = 13;
            this.lblUnsuccessfulLogin1.Text = "Login unsuccessful!";
            // 
            // lblLogIn6
            // 
            this.lblLogIn6.AutoSize = true;
            this.lblLogIn6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn6.ForeColor = System.Drawing.Color.Black;
            this.lblLogIn6.Location = new System.Drawing.Point(57, 115);
            this.lblLogIn6.Name = "lblLogIn6";
            this.lblLogIn6.Size = new System.Drawing.Size(216, 20);
            this.lblLogIn6.TabIndex = 12;
            this.lblLogIn6.Text = "Fill in your details to continue";
            // 
            // lblLogIn5
            // 
            this.lblLogIn5.AutoSize = true;
            this.lblLogIn5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn5.ForeColor = System.Drawing.Color.Black;
            this.lblLogIn5.Location = new System.Drawing.Point(53, 55);
            this.lblLogIn5.Name = "lblLogIn5";
            this.lblLogIn5.Size = new System.Drawing.Size(118, 44);
            this.lblLogIn5.TabIndex = 12;
            this.lblLogIn5.Text = "Login";
            // 
            // tbxKey
            // 
            this.tbxKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxKey.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKey.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxKey.Location = new System.Drawing.Point(71, 221);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(307, 19);
            this.tbxKey.TabIndex = 6;
            this.tbxKey.Text = "Password";
            this.tbxKey.Enter += new System.EventHandler(this.tbxKey_Enter);
            this.tbxKey.Leave += new System.EventHandler(this.tbxKey_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(61, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(61, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 1);
            this.panel2.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 470);
            this.Controls.Add(this.panelLoginInfo);
            this.Controls.Add(this.panelLoginInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.panelLoginInfo.ResumeLayout(false);
            this.panelLoginInfo.PerformLayout();
            this.panelLoginInput.ResumeLayout(false);
            this.panelLoginInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLoginInfo;
        private System.Windows.Forms.Label lblLogIn4;
        private System.Windows.Forms.Label lblLogIn3;
        private System.Windows.Forms.Label lblLogIn1;
        private System.Windows.Forms.Label lblLogIn2;
        private System.Windows.Forms.Panel panelLoginInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Label lblLogIn5;
        private System.Windows.Forms.Label lblLogIn6;
        private System.Windows.Forms.Label lblUnsuccessfulLogin2;
        private System.Windows.Forms.Label lblUnsuccessfulLogin1;
    }
}

