using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.Registration
{
    public partial class Registration : Form
    {
        TextBox[] textBoxes;
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBoxShowPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassw.Checked)
            {
                textBoxPassw.PasswordChar = char.MinValue;
            }
            else
            {
                textBoxPassw.PasswordChar = '*';
            }

        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar != '_')
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymb = "!?_";
            if (!char.IsLetterOrDigit(e.KeyChar) && !allowSymb.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            textBoxes = new TextBox[]
            {
                textBoxName,
                textBoxSurname,
                textBoxPosition,
                textBoxLogin,
                textBoxPassw,
                textBoxRepeatPassw
            };
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = string.Empty;
            try
            {
                RegistrUserInDataBase.CheckInputFields(textBoxes);
                RegistrUserInDataBase.AddNewUser(textBoxes, "wrk");
                ConfirmRegistration();
            }
            catch (ArgumentException ex)
            {
                ErrorLabel.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmRegistration()
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = string.Empty;
        }
    }
}
