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

        private async void CheckInputDataInBD()
        {
            string type = await Task.Run(() =>
            {
                try
                {
                    CheckInputAndLoadForm.CheckInputFields(textBoxLogin.Text.Length, textBoxPassword.Text.Length);
                    return CheckInputAndLoadForm.CheckInputDataReturnType(textBoxLogin.Text, textBoxPassword.Text);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            });

            animator.StopDrawing();
            ChangeEnabledOfControl(true);
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

        private void ChangeEnabledOfControl(bool enabled)
        {
            foreach (Control elem in this.Controls)
            {
                elem.Enabled = enabled;
            }
        }

        Main_form.LoadAnimator animator = null;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            ChangeEnabledOfControl(false);
            CheckInputDataInBD();
            animator = new Main_form.LoadAnimator(this, Graphics.FromHwnd(this.Handle));
            animator.StartAnimation();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void labelShowPassw_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = labelShowPassw.Text == "Показать" ? char.MinValue : '*';
            labelShowPassw.Text = labelShowPassw.Text == "Показать" ? "Скрыть" : "Показать";
        }
    }
}
