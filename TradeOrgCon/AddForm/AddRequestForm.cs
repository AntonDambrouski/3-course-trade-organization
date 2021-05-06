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
    public partial class AddRequestForm : Form
    {
        public AddRequestForm()
        {
            InitializeComponent();
        }

        private void AddRequestForm_Load(object sender, EventArgs e)
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
                GetIdFromDBToComboBoxes.GetIdForComboBoxes(new SqlCommand("SELECT Id FROM Поставщики", sqlConnection), out int[] suppliersId);
                GetIdFromDBToComboBoxes.GetIdForComboBoxes(new SqlCommand("SELECT Id FROM Склад_организации", sqlConnection), out int[] productId);
                comboBoxProductId.Items.Clear();
                comboBoxSuppliertId.Items.Clear();
                if (!(suppliersId is null))
                {
                    foreach (var supId in suppliersId)
                    {
                        comboBoxSuppliertId.Items.Add(supId);
                    }
                }

                if (!(productId is null))
                {
                    foreach (var prodId in productId)
                    {
                        comboBoxProductId.Items.Add(prodId);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxSuppliertId.SelectedItem is null) || (comboBoxProductId.SelectedItem is null))
                {
                    throw new ArgumentException("Не выбраны выдвигающиеся поля!");
                }

                AddRequestInDataBase.CheckOnCorrectInput(maskedTextBoxDateOfSupply.Text, comboBoxProductId.SelectedItem.ToString(),
                    comboBoxSuppliertId.SelectedItem.ToString(), textBoxCount.Text);
                AddRequestInDataBase.InsertRequestIntoDB(maskedTextBoxDateOfSupply.Text, comboBoxProductId.SelectedItem.ToString(),
                    comboBoxSuppliertId.SelectedItem.ToString(), textBoxCount.Text);
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

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void labelToday_Click(object sender, EventArgs e)
        {
            maskedTextBoxDateOfSupply.Text = System.DateTime.Now.ToShortDateString();
        }
    }
}
