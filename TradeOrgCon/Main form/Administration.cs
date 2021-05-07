using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TradeOrgCon.Main_form
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void LoadSearchAndRangeBoxes(string[] searchBy, string[] rangeBy)
        {
            comboBoxSrchRange.Items.Clear();
            comboBoxSearchBy.Items.Clear();
            comboBoxSearchBy.DropDownWidth = comboBoxSrchRange.DropDownWidth = 150;
            if (searchBy is null)
            {
                comboBoxSearchBy.Enabled = textBoxValToSearch.Enabled = false;
            }
            else
            {
                comboBoxSearchBy.Enabled = textBoxValToSearch.Enabled = true;
            }

            foreach (var item in searchBy)
            {
                comboBoxSearchBy.Items.Add(item);
                if (item.Length * 10 > comboBoxSearchBy.DropDownWidth)
                {
                    comboBoxSearchBy.DropDownWidth = item.Length * 10;
                }
            }

            if (rangeBy is null)
            {
                comboBoxSrchRange.Enabled = false;
                textBoxChsFrom.Enabled = textBoxChsTo.Enabled = false;
            }
            else
            {
                comboBoxSrchRange.Enabled = true;
                textBoxChsFrom.Enabled = textBoxChsTo.Enabled = true;
                foreach (var item in rangeBy)
                {
                    comboBoxSrchRange.Items.Add(item);
                    if (item.Length * 10 > comboBoxSearchBy.DropDownWidth)
                    {
                        comboBoxSrchRange.DropDownWidth = item.Length * 10;
                    }
                }
            }
        }

        //MenuItem choose
        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadSuppliers(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxChsFrom_EnabledChanged(object sender, EventArgs e)
        {
            if (!textBoxChsTo.Enabled)
            {
                textBoxChsTo.BackColor = textBoxChsFrom.BackColor = SystemColors.ControlLight;
            }
            else
            {
                textBoxChsTo.BackColor = textBoxChsFrom.BackColor = Color.AliceBlue;
            }

        }

        private void продавциToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadSellers(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadRequest(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemTradOrganization_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadTradeOrganization(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemStore_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadStore(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadSales(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadClients(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void учётныеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonPrint.Enabled = buttonSaveInWord.Enabled = buttonSendEmail.Enabled = false;
            try
            {
                LoadSearchAndChooseInfoByClickButton.LoadUserAccounts(this.dataGridView1, out string[] searchBy, out string[] rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
                dataGridView1.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Search

        string searchString = null;
        string searchRange = null;
        private void textBoxValToSearch_TextChanged(object sender, EventArgs e)
        {
            ErrorSearchInputlabel.Text = string.Empty;
            if (textBoxValToSearch.Text.Length != 0)
            {
                try
                {
                    if (comboBoxSearchBy.SelectedItem is null)
                    {
                        throw new ArgumentException("Не выбрано поле для поиска!");
                    }

                    if (long.TryParse(textBoxValToSearch.Text, out long valueType) || DateTime.TryParse(textBoxValToSearch.Text, out DateTime data))
                    {
                        searchString = $"{comboBoxSearchBy.SelectedItem} = '{textBoxValToSearch.Text}'";
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = searchString + (searchRange is null ? string.Empty : " AND " + searchRange);
                    }
                    else
                    {
                        searchString = $"{comboBoxSearchBy.SelectedItem} LIKE '%{textBoxValToSearch.Text}%'";
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = searchString + (searchRange is null ? string.Empty : " AND " + searchRange);
                    }

                }
                catch (ArgumentException ex)
                {
                    ErrorSearchInputlabel.Text = ex.Message;
                }
                catch (Exception)
                {
                    ErrorSearchInputlabel.Text = "Некоррекнтые данные!";
                    searchString = null;
                }
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = searchRange is null ? string.Empty : searchRange;
                searchString = null;
            }
        }

        private void textBoxChsFrom_TextChanged(object sender, EventArgs e)
        {
            ErrorChsLabel.Text = string.Empty;
            if (textBoxChsTo.Text.Length != 0 && textBoxChsFrom.Text.Length != 0)
            {
                try
                {
                    if (comboBoxSrchRange.SelectedItem is null)
                    {
                        throw new ArgumentException("Не выбрано поле для поиска!");
                    }

                    searchRange = $"{comboBoxSrchRange.SelectedItem}  >= '{textBoxChsFrom.Text}' AND {comboBoxSrchRange.SelectedItem} <= '{textBoxChsTo.Text}'";
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = searchRange + (searchString is null ? string.Empty : " AND " + searchString);
                }
                catch (ArgumentException ex)
                {
                    ErrorChsLabel.Text = ex.Message;
                }
                catch (Exception)
                {
                    ErrorChsLabel.Text = "Некоррекнтые данные!";
                }
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = searchString is null ? string.Empty : searchString;
                searchRange = null;
            }
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValToSearch.Clear();
            searchString = null;
        }

        private void comboBoxSrchRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxChsTo.Clear();
            textBoxChsFrom.Clear();
            searchRange = null;
        }

        //Buttons

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (поставщикиToolStripMenuItem.Checked)
            {
                AddForm.AddSuppliesForm addSupplies = new AddForm.AddSuppliesForm();
                if (addSupplies.ShowDialog() == DialogResult.OK)
                {
                    поставщикиToolStripMenuItem_Click(null, null);
                }
            }

            if (продавциToolStripMenuItem.Checked)
            {
                AddForm.AddSellersForm addSellers = new AddForm.AddSellersForm();
                if (addSellers.ShowDialog() == DialogResult.OK)
                {
                    продавциToolStripMenuItem_Click(null, null);
                }
            }

            if (продажиToolStripMenuItem.Checked)
            {
                AddForm.AddSalesForm addSales = new AddForm.AddSalesForm();
                if (addSales.ShowDialog() == DialogResult.OK)
                {
                    продажиToolStripMenuItem_Click(null, null);
                }
            }

            if (toolStripMenuItemStore.Checked)
            {
                AddForm.AddStoreForm addStore = new AddForm.AddStoreForm();
                if (addStore.ShowDialog() == DialogResult.OK)
                {
                    toolStripMenuItemStore_Click(null, null);
                }
            }

            if (toolStripMenuItemTradOrganization.Checked)
            {
                AddForm.AddOutletForm addOutlet = new AddForm.AddOutletForm();
                if (addOutlet.ShowDialog() == DialogResult.OK)
                {
                    toolStripMenuItemTradOrganization_Click(null, null);
                }
            }

            if (заявкиToolStripMenuItem.Checked)
            {
                AddForm.AddRequestForm addRequest = new AddForm.AddRequestForm();
                if (addRequest.ShowDialog() == DialogResult.OK)
                {
                    заявкиToolStripMenuItem_Click(null, null);
                }
            }

            if (покупателиToolStripMenuItem.Checked)
            {
                AddForm.AddClientForm addClient = new AddForm.AddClientForm();
                if (addClient.ShowDialog() == DialogResult.OK)
                {
                    покупателиToolStripMenuItem_Click(null, null);
                }
            }

            if (учётныеЗаписиToolStripMenuItem.Checked)
            {
                AddForm.AddUserAccountForm addUserAccount = new AddForm.AddUserAccountForm();
                if (addUserAccount.ShowDialog() == DialogResult.OK)
                {
                    учётныеЗаписиToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void поставщикиToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = buttonDel.Enabled = buttonPrint.Enabled = buttonSaveInWord.Enabled = buttonSendEmail.Enabled = true;
            dataGridView1.ReadOnly = true;
            searchString = searchRange = null;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Selected)
                {
                    item.Checked = true;
                    item.BackColor = Color.LightGreen;
                }
                else
                {
                    item.Checked = false;
                    item.BackColor = Color.AliceBlue;
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK && printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void Administration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            LoadSearchAndChooseInfoByClickButton.SaveChanges();
        }

        private void Administration_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 1200)
            {
                this.Width = 1200;
                CenterToScreen();
            }

            if (this.Height < 700)
            {
                this.Height = 700;
                CenterToScreen();
            }
        }

        private void buttonSaveInWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Additional_buttons.SaveInWordFile.Export_Data_To_Word(dataGridView1, sfd.FileName, GetTableName());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetTableName()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Checked)
                {
                    return item.Text;
                }
            }

            return string.Empty;
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Additional_buttons.SendTableOnEmail.IsConnectedToInternet())
                {
                    throw new Exception("Нет подключения к интернету");
                }

                Additional_buttons.InputEmailForm inputEmail = new Additional_buttons.InputEmailForm();
                if (inputEmail.ShowDialog() == DialogResult.OK)
                {
                    Additional_buttons.SendTableOnEmail.IsValidEmail(inputEmail.textBoxEmail.Text);
                    Additional_buttons.SendTableOnEmail.SendEmail(dataGridView1, inputEmail.textBoxEmail.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Send error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Additional_buttons.PrintTable.GetBmpForPrint(dataGridView1, printDocument.DefaultPageSettings.Bounds), 0, 0);
        }

        private void linkLabelChangeAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("TradeOrgCon.exe");
            this.Close();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void buttonChangeFont_Click(object sender, EventArgs e)
        {
            if (buttonChangeFont.Text == "Увеличить")
            {
                buttonDel.Font = buttonPrint.Font = buttonSaveInWord.Font = buttonSendEmail.Font = buttonAdd.Font = new Font("Consolas", 12);
                buttonSendEmail.Font = new Font("Consolas", 11);
                groupBoxChsDataBy.Font = groupBoxSearch.Font = dataGridView1.Font = new Font("Consolas", 14);
                comboBoxSearchBy.Font = comboBoxSrchRange.Font = textBoxChsFrom.Font = textBoxChsTo.Font = textBoxValToSearch.Font = new Font("Consolas", 14);
            }
            else
            {
                buttonDel.Font = buttonPrint.Font = buttonSaveInWord.Font = buttonSendEmail.Font = buttonAdd.Font = new Font("Consolas", 9);
                groupBoxChsDataBy.Font = groupBoxSearch.Font = new Font("Consolas", 12);
                dataGridView1.Font = new Font("Consolas", 10);
                comboBoxSearchBy.Font = comboBoxSrchRange.Font = textBoxChsFrom.Font = textBoxChsTo.Font = textBoxValToSearch.Font = new Font("Consolas", 12);

            }

            buttonChangeFont.Text = buttonChangeFont.Text == "Увеличить" ? "Уменьшить" : "Увеличить";
        }

        private void buttonAboutProgram_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("Readme.txt"))
                {
                    Forms_about.RestoreAboutFile.CreateReadMeFile();
                }

                System.Diagnostics.Process.Start("Readme.txt");
            }
            catch (Exception) {/*nothing*/};
        }
    }
}
