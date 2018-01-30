using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLOViewer
{
    public partial class Form_iLO : Form
    {
        public iLOConnection iLOConnection { get; private set; }

        public Form_iLO(iLOConnection iLOConnection = null)
        {
            this.iLOConnection = iLOConnection;

            InitializeComponent();
        }

        private void Form_iLO_Load(object sender, EventArgs e)
        {
            if (this.iLOConnection != null)
            {
                this.textBox_Name.Text = this.iLOConnection.Name;
                this.checkBox_Https.Checked = this.iLOConnection.Https;
                this.textBox_Host.Text = this.iLOConnection.Host;
                this.numericUpDown_Port.Value = this.iLOConnection.Port;
                this.textBox_User.Text = this.iLOConnection.User;
                this.textBox_Password.Text = this.iLOConnection.UserPassword;
            }
        }

        private void button_SaveAndExit_Click(object sender, EventArgs e)
        {
            if (this.ValidateInput())
            {
                this.iLOConnection = new iLOConnection();
                this.iLOConnection.Name = this.textBox_Name.Text;
                this.iLOConnection.Https = this.checkBox_Https.Checked;
                this.iLOConnection.Host = this.textBox_Host.Text;
                this.iLOConnection.Port = (int)this.numericUpDown_Port.Value;
                this.iLOConnection.User = this.textBox_User.Text;
                this.iLOConnection.UserPassword = this.textBox_Password.Text;

                this.Close();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            Func<TextBox, bool> validateEmpty = (textBox) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show(string.Format("{0} cannot be empty or whitespace.", textBox.Tag.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            };

            if (!validateEmpty(this.textBox_Name))
            {
                return false;
            }

            if (!validateEmpty(this.textBox_Host))
            {
                return false;
            }

            if (!validateEmpty(this.textBox_User))
            {
                return false;
            }

            if (!validateEmpty(this.textBox_Password))
            {
                return false;
            }

            return true;
        }
    }
}
