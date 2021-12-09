namespace Project_Utility_Tab_Prototype
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UtilityBox = new System.Windows.Forms.TextBox();
            this.AddUTBTN = new System.Windows.Forms.Button();
            this.DamagedBTN = new System.Windows.Forms.RadioButton();
            this.BrokenBTN = new System.Windows.Forms.RadioButton();
            this.InRepairBTN = new System.Windows.Forms.RadioButton();
            this.WorkingBTN = new System.Windows.Forms.RadioButton();
            this.RemoveUTBTN = new System.Windows.Forms.Button();
            this.ReserveBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(550, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 260);
            this.listBox1.TabIndex = 0;
            // 
            // UtilityBox
            // 
            this.UtilityBox.Location = new System.Drawing.Point(128, 324);
            this.UtilityBox.Name = "UtilityBox";
            this.UtilityBox.Size = new System.Drawing.Size(100, 22);
            this.UtilityBox.TabIndex = 3;
            // 
            // AddUTBTN
            // 
            this.AddUTBTN.Location = new System.Drawing.Point(63, 352);
            this.AddUTBTN.Name = "AddUTBTN";
            this.AddUTBTN.Size = new System.Drawing.Size(100, 23);
            this.AddUTBTN.TabIndex = 4;
            this.AddUTBTN.Text = "Add Utility";
            this.AddUTBTN.UseVisualStyleBackColor = true;
            this.AddUTBTN.Click += new System.EventHandler(this.AddUTBTN_Click);
            // 
            // DamagedBTN
            // 
            this.DamagedBTN.AutoSize = true;
            this.DamagedBTN.Location = new System.Drawing.Point(470, 285);
            this.DamagedBTN.Name = "DamagedBTN";
            this.DamagedBTN.Size = new System.Drawing.Size(89, 20);
            this.DamagedBTN.TabIndex = 5;
            this.DamagedBTN.TabStop = true;
            this.DamagedBTN.Text = "Damaged";
            this.DamagedBTN.UseVisualStyleBackColor = true;
            this.DamagedBTN.CheckedChanged += new System.EventHandler(this.DamagedBTN_CheckedChanged);
            // 
            // BrokenBTN
            // 
            this.BrokenBTN.AutoSize = true;
            this.BrokenBTN.Location = new System.Drawing.Point(565, 285);
            this.BrokenBTN.Name = "BrokenBTN";
            this.BrokenBTN.Size = new System.Drawing.Size(71, 20);
            this.BrokenBTN.TabIndex = 6;
            this.BrokenBTN.TabStop = true;
            this.BrokenBTN.Text = "Broken";
            this.BrokenBTN.UseVisualStyleBackColor = true;
            this.BrokenBTN.CheckedChanged += new System.EventHandler(this.BrokenBTN_CheckedChanged);
            // 
            // InRepairBTN
            // 
            this.InRepairBTN.AutoSize = true;
            this.InRepairBTN.Location = new System.Drawing.Point(642, 285);
            this.InRepairBTN.Name = "InRepairBTN";
            this.InRepairBTN.Size = new System.Drawing.Size(82, 20);
            this.InRepairBTN.TabIndex = 7;
            this.InRepairBTN.TabStop = true;
            this.InRepairBTN.Text = "In Repair";
            this.InRepairBTN.UseVisualStyleBackColor = true;
            this.InRepairBTN.CheckedChanged += new System.EventHandler(this.InRepairBTN_CheckedChanged);
            // 
            // WorkingBTN
            // 
            this.WorkingBTN.AutoSize = true;
            this.WorkingBTN.Location = new System.Drawing.Point(377, 285);
            this.WorkingBTN.Name = "WorkingBTN";
            this.WorkingBTN.Size = new System.Drawing.Size(78, 20);
            this.WorkingBTN.TabIndex = 8;
            this.WorkingBTN.TabStop = true;
            this.WorkingBTN.Text = "Working";
            this.WorkingBTN.UseVisualStyleBackColor = true;
            this.WorkingBTN.CheckedChanged += new System.EventHandler(this.WorkingBTN_CheckedChanged);
            // 
            // RemoveUTBTN
            // 
            this.RemoveUTBTN.Location = new System.Drawing.Point(189, 352);
            this.RemoveUTBTN.Name = "RemoveUTBTN";
            this.RemoveUTBTN.Size = new System.Drawing.Size(115, 23);
            this.RemoveUTBTN.TabIndex = 9;
            this.RemoveUTBTN.Text = "Remove Utility";
            this.RemoveUTBTN.UseVisualStyleBackColor = true;
            this.RemoveUTBTN.Click += new System.EventHandler(this.RemoveUTBTN_Click);
            // 
            // ReserveBTN
            // 
            this.ReserveBTN.Location = new System.Drawing.Point(584, 339);
            this.ReserveBTN.Name = "ReserveBTN";
            this.ReserveBTN.Size = new System.Drawing.Size(75, 23);
            this.ReserveBTN.TabIndex = 10;
            this.ReserveBTN.Text = "Reserve";
            this.ReserveBTN.UseVisualStyleBackColor = true;
            this.ReserveBTN.Click += new System.EventHandler(this.ReserveBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(21, 35);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(79, 36);
            this.TimeLabel.TabIndex = 11;
            this.TimeLabel.Text = "Time";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(21, 78);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 28);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ReserveBTN);
            this.Controls.Add(this.RemoveUTBTN);
            this.Controls.Add(this.WorkingBTN);
            this.Controls.Add(this.InRepairBTN);
            this.Controls.Add(this.BrokenBTN);
            this.Controls.Add(this.DamagedBTN);
            this.Controls.Add(this.AddUTBTN);
            this.Controls.Add(this.UtilityBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox UtilityBox;
        private System.Windows.Forms.Button AddUTBTN;
        private System.Windows.Forms.RadioButton DamagedBTN;
        private System.Windows.Forms.RadioButton BrokenBTN;
        private System.Windows.Forms.RadioButton InRepairBTN;
        private System.Windows.Forms.RadioButton WorkingBTN;
        private System.Windows.Forms.Button RemoveUTBTN;
        private System.Windows.Forms.Button ReserveBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}

