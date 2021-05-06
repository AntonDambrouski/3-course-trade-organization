using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.AddForm
{
    public partial class AddSuppliesForm : Form
    {
        public AddSuppliesForm()
        {
            InitializeComponent();
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
                if (comboBoxCategory.SelectedItem is null)
                {
                    throw new ArgumentException("Не выбрана категория!");
                }

                if (!maskedTextBoxPhone.MaskCompleted)
                {
                    throw new ArgumentException("Не введён номер телефона!");
                }

                AddSupplierInDataBase.CheckOnCorrectInput(textBoxNameOrg.Text, textBoxAdress.Text, maskedTextBoxPhone.MaskedTextProvider.ToDisplayString(), comboBoxCategory.SelectedItem.ToString());
                AddSupplierInDataBase.InsertClientIntoDB(textBoxNameOrg.Text, textBoxAdress.Text, maskedTextBoxPhone.MaskedTextProvider.ToDisplayString(), comboBoxCategory.SelectedItem.ToString());
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
