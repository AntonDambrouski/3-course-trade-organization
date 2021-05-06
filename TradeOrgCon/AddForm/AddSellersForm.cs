using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.AddForm
{
    public partial class AddSellersForm : Form
    {
        public AddSellersForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddSellersForm_Load(object sender, EventArgs e)
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
                GetIdFromDBToComboBoxes.GetIdForComboBoxes(new SqlCommand("SELECT Id FROM Торговая_точка", sqlConnection), out int[] organizationsId);
                comboBoxIdTradeOrg.Items.Clear();
                if (!(organizationsId is null))
                {
                    foreach (var organizationId in organizationsId)
                    {
                        comboBoxIdTradeOrg.Items.Add(organizationId);
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

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBoxAdress_KeyPress(object sender, KeyPressEventArgs e)
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
                if (comboBoxIdTradeOrg.SelectedItem is null)
                {
                    throw new ArgumentException("Не выбран Id торговой точки!");
                }

                AddSellersInDataBase.CheckOnCorrectInput(textBoxSurname.Text, textBoxName.Text, textBoxSalary.Text, comboBoxIdTradeOrg.SelectedItem.ToString());
                AddSellersInDataBase.InsertSellerIntoDB(textBoxSurname.Text, textBoxName.Text, textBoxSalary.Text, comboBoxIdTradeOrg.SelectedItem.ToString());
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
    }
}
