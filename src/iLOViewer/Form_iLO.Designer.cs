namespace iLOViewer
{
    partial class Form_iLO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_iLO));
            this.button_SaveAndExit = new System.Windows.Forms.Button();
            this.groupBox_iLO = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Port = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Https = new System.Windows.Forms.CheckBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.label_Host = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox_iLO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SaveAndExit
            // 
            this.button_SaveAndExit.Location = new System.Drawing.Point(12, 225);
            this.button_SaveAndExit.Name = "button_SaveAndExit";
            this.button_SaveAndExit.Size = new System.Drawing.Size(125, 38);
            this.button_SaveAndExit.TabIndex = 0;
            this.button_SaveAndExit.Text = "&Save and Exit";
            this.button_SaveAndExit.UseVisualStyleBackColor = true;
            this.button_SaveAndExit.Click += new System.EventHandler(this.button_SaveAndExit_Click);
            // 
            // groupBox_iLO
            // 
            this.groupBox_iLO.Controls.Add(this.numericUpDown_Port);
            this.groupBox_iLO.Controls.Add(this.checkBox_Https);
            this.groupBox_iLO.Controls.Add(this.textBox_Password);
            this.groupBox_iLO.Controls.Add(this.label_Password);
            this.groupBox_iLO.Controls.Add(this.textBox_User);
            this.groupBox_iLO.Controls.Add(this.label_User);
            this.groupBox_iLO.Controls.Add(this.label_Port);
            this.groupBox_iLO.Controls.Add(this.textBox_Host);
            this.groupBox_iLO.Controls.Add(this.label_Host);
            this.groupBox_iLO.Controls.Add(this.textBox_Name);
            this.groupBox_iLO.Controls.Add(this.label_Name);
            this.groupBox_iLO.Location = new System.Drawing.Point(12, 12);
            this.groupBox_iLO.Name = "groupBox_iLO";
            this.groupBox_iLO.Size = new System.Drawing.Size(286, 207);
            this.groupBox_iLO.TabIndex = 1;
            this.groupBox_iLO.TabStop = false;
            this.groupBox_iLO.Text = "iLO";
            // 
            // numericUpDown_Port
            // 
            this.numericUpDown_Port.Location = new System.Drawing.Point(104, 110);
            this.numericUpDown_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_Port.Name = "numericUpDown_Port";
            this.numericUpDown_Port.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown_Port.TabIndex = 13;
            this.numericUpDown_Port.Value = new decimal(new int[] {
            443,
            0,
            0,
            0});
            // 
            // checkBox_Https
            // 
            this.checkBox_Https.AutoSize = true;
            this.checkBox_Https.Checked = true;
            this.checkBox_Https.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Https.Location = new System.Drawing.Point(104, 56);
            this.checkBox_Https.Name = "checkBox_Https";
            this.checkBox_Https.Size = new System.Drawing.Size(61, 19);
            this.checkBox_Https.TabIndex = 12;
            this.checkBox_Https.Text = "Https";
            this.checkBox_Https.UseVisualStyleBackColor = true;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(104, 168);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(150, 23);
            this.textBox_Password.TabIndex = 11;
            this.textBox_Password.Tag = "Password";
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(28, 171);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(70, 15);
            this.label_Password.TabIndex = 10;
            this.label_Password.Text = "Password:";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(104, 139);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(150, 23);
            this.textBox_User.TabIndex = 9;
            this.textBox_User.Tag = "User";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(28, 142);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(42, 15);
            this.label_User.TabIndex = 8;
            this.label_User.Text = "User:";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(28, 113);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(42, 15);
            this.label_Port.TabIndex = 6;
            this.label_Port.Text = "Port:";
            // 
            // textBox_Host
            // 
            this.textBox_Host.Location = new System.Drawing.Point(104, 81);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.Size = new System.Drawing.Size(150, 23);
            this.textBox_Host.TabIndex = 5;
            this.textBox_Host.Tag = "Host/IP";
            // 
            // label_Host
            // 
            this.label_Host.AutoSize = true;
            this.label_Host.Location = new System.Drawing.Point(28, 84);
            this.label_Host.Name = "label_Host";
            this.label_Host.Size = new System.Drawing.Size(63, 15);
            this.label_Host.TabIndex = 4;
            this.label_Host.Text = "Host/IP:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(104, 27);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(150, 23);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.Tag = "Name";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(28, 30);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(42, 15);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(143, 225);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(155, 38);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "&Exit without Save";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form_iLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 274);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox_iLO);
            this.Controls.Add(this.button_SaveAndExit);
            this.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_iLO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iLO";
            this.Load += new System.EventHandler(this.Form_iLO_Load);
            this.groupBox_iLO.ResumeLayout(false);
            this.groupBox_iLO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SaveAndExit;
        private System.Windows.Forms.GroupBox groupBox_iLO;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox textBox_Host;
        private System.Windows.Forms.Label label_Host;
        private System.Windows.Forms.CheckBox checkBox_Https;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.NumericUpDown numericUpDown_Port;
    }
}