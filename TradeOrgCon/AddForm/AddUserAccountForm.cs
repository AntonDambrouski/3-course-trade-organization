using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.AddForm
{
    public partial class AddUserAccountForm : Form
    {
        public AddUserAccountForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedItem is null)
                {
                    throw new ArgumentException("Не выбран тип!");
                }
                TradeOrgCon.Registration.RegistrUserInDataBase.AddNewUser(textBoxName.Text, textBoxSurname.Text, textBoxPosition.Text,
                   textBoxLogin.Text, textBoxPassw.Text, comboBoxType.SelectedItem.ToString());
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBoxPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymb = "!?_";
            if (!char.IsLetterOrDigit(e.KeyChar) && !allowSymb.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
