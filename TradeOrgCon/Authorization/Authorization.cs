using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.Authorization
{
    public partial class Authorization : Form
    {
        Main_form.Administration administration = null;
        Main_form.Worker worker = null;
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputAndLoadForm.CheckInputFields(textBoxLogin.Text.Length, textBoxPassword.Text.Length);
                string type = CheckInputAndLoadForm.CheckInputDataReturnType(textBoxLogin.Text, textBoxPassword.Text);
                if (type == "adm")
                {
                    this.Hide();
                    administration = new Main_form.Administration();
                    administration.Show();
                }

                if (type == "wrk")
                {
                    worker = new Main_form.Worker();
                    this.Hide();
                    worker.Show();
                }
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "login")
                {
                    labelErrorLogin.Text = "Неверный логин";
                }
                else if (ex.ParamName == "password")
                {
                    labelErrorPassw.Text = "Неверный пароль";
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegistr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration.Registration registration = new Registration.Registration();
            if (registration.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                worker = new Main_form.Worker();
                worker.Show();
            }
        }

        private void linkLabelForgotPassw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Для восстановления пароля обратитесь к администратору!", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            labelErrorLogin.Text = string.Empty;
            labelErrorPassw.Text = string.Empty;
        }

        private void labelShowPassw_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = labelShowPassw.Text == "Показать" ? char.MinValue : '*';
            labelShowPassw.Text = labelShowPassw.Text == "Показать" ? "Скрыть" : "Показать";
        }
    }
}
