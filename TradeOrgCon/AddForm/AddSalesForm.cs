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
    public partial class AddSalesForm : Form
    {
        public AddSalesForm()
        {
            InitializeComponent();
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddSalesForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                sqlConnection.Open();
                GetIdFromDBToComboBoxes.GetIdForComboBoxes(new SqlCommand("SELECT Id FROM Продавцы", sqlConnection), out int[] sellersId);
                GetIdFromDBToComboBoxes.GetIdForComboBoxes(new SqlCommand("SELECT Id FROM Склад_организации", sqlConnection), out int[] productsId);
                GetIdFromDBToComboBoxes.GetIdForComboBoxes(new SqlCommand("SELECT Id FROM Покупатели", sqlConnection), out int[] clientsId);
                comboBoxProductId.Items.Clear();
                comboBoxClientId.Items.Clear();
                comboBoxSellerId.Items.Clear();
                if (!(sellersId is null))
                {
                    foreach (var sellerId in sellersId)
                    {
                        comboBoxSellerId.Items.Add(sellerId);
                    }
                }

                if (!(productsId is null))
                {
                    foreach (var prodId in productsId)
                    {
                        comboBoxProductId.Items.Add(prodId);
                    }
                }

                if (!(clientsId is null))
                {
                    foreach (var clientId in clientsId)
                    {
                        comboBoxClientId.Items.Add(clientId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!(sqlConnection is null))
                {
                    sqlConnection.Close();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxProductId.SelectedItem is null) || (comboBoxSellerId.SelectedItem is null))
                {
                    throw new ArgumentException("Не выбраны выдвигающиеся поля!");
                }

                string clientId = comboBoxClientId.SelectedItem is null ? null : comboBoxClientId.SelectedItem.ToString();
                AddSalesInDataBase.CheckOnCorrectInput(maskedTextBoxDateOfSales.Text, comboBoxProductId.SelectedItem.ToString(), comboBoxSellerId.SelectedItem.ToString(), textBoxCount.Text, textBoxPrice.Text);
                AddSalesInDataBase.InsertSalesIntoDB(maskedTextBoxDateOfSales.Text, clientId,
                    comboBoxProductId.SelectedItem.ToString(), comboBoxSellerId.SelectedItem.ToString(), textBoxCount.Text, textBoxPrice.Text);
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

        private void linkLabelAddClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                LoadComboBoxes();
            }
        }

        private void labelToday_Click(object sender, EventArgs e)
        {
            maskedTextBoxDateOfSales.Text = System.DateTime.Now.ToShortDateString();
        }
    }
}
