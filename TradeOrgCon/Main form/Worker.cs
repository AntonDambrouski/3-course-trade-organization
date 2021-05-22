using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.Main_form
{
    public partial class Worker : Form
    {
        string searchString = null;
        string searchRange = null;

        public Worker()
        {
            InitializeComponent();
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.Landscape = true;
        }
        private void LoadSearchAndRangeBoxes(Dictionary<string, string> searchBy, Dictionary<string, string> rangeBy)
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

            foreach (var item in searchBy.Keys)
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
                foreach (var item in rangeBy.Keys)
                {
                    comboBoxSrchRange.Items.Add(item);
                    if (item.Length * 10 > comboBoxSearchBy.DropDownWidth)
                    {
                        comboBoxSrchRange.DropDownWidth = item.Length * 10;
                    }
                }
            }
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadWorkerFormByChoosingButton.LoadSuppliers(this.dataGridView1, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy);
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
                LoadWorkerFormByChoosingButton.LoadSales(this.dataGridView1, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy);
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
                LoadWorkerFormByChoosingButton.LoadClients(this.dataGridView1, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void торговаяТочкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadWorkerFormByChoosingButton.LoadTradePoint(this.dataGridView1, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void продавцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadWorkerFormByChoosingButton.LoadSellers(this.dataGridView1, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy);
                LoadSearchAndRangeBoxes(searchBy, rangeBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Worker_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 1500)
            {
                this.Width = 1500;
                CenterToScreen();
            }

            if (this.Height < 700)
            {
                this.Height = 700;
                CenterToScreen();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Additional_buttons.PrintTable.GetBmpForPrint(dataGridView1, printDocument.DefaultPageSettings.Bounds), 0, 0);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK && printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void buttonAddStatement_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(comboBoxSearchBy.SelectedItem is null) && textBoxValToSearch.Text.Length != 0)
                {
                    if (long.TryParse(textBoxValToSearch.Text, out long valueType) || DateTime.TryParse(textBoxValToSearch.Text, out DateTime date))
                    {
                        listBoxStatement.Items.Add($"{comboBoxSearchBy.SelectedItem} = '{textBoxValToSearch.Text}'");
                        textBoxValToSearch.Clear();
                    }
                    else
                    {
                        listBoxStatement.Items.Add($"{comboBoxSearchBy.SelectedItem} LIKE '%{textBoxValToSearch.Text}%'");
                        textBoxValToSearch.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка добавления.\nНе выбран критерий или поле поиска пустое.", "Ошибка добавления условия", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные", "Ошибка добавления условия", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

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
                        UpdateTableByFilter();
                    }
                    else
                    {
                        searchString = $"{comboBoxSearchBy.SelectedItem} LIKE '%{textBoxValToSearch.Text}%'";
                        UpdateTableByFilter();
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
                searchString = null;
                UpdateTableByFilter();
            }
        }

        private void UpdateTableByFilter()
        {
            string filterStatement = string.Empty;
            bool firstAdding = true;
            foreach (var item in listBoxStatement.Items)
            {
                if (firstAdding)
                {
                    filterStatement += item.ToString();
                    firstAdding = !firstAdding;
                }
                else
                {
                    filterStatement += " AND " + item.ToString();
                }
            }

            filterStatement += searchString is null ? string.Empty : filterStatement.Length == 0 ? searchString : " AND " + searchString;
            filterStatement += searchRange is null ? string.Empty : filterStatement.Length == 0 ? searchRange : " AND " + searchRange;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterStatement;
        }

        private void buttonDelStatement_Click(object sender, EventArgs e)
        {
            if (listBoxStatement.SelectedIndex > -1)
            {
                listBoxStatement.Items.Remove(listBoxStatement.SelectedItem);
                UpdateTableByFilter();
            }
            else
            {
                MessageBox.Show("Не выбрано условие для удаления.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxStatement.Items.Count != 0)
            {
                listBoxStatement.Items.Clear();
                UpdateTableByFilter();
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
                    UpdateTableByFilter();
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
                searchRange = null;
                UpdateTableByFilter();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            labelMainInfo1.Text = "Всего записей: " + dataGridView1.Rows.Count.ToString();
            if (поставщикиToolStripMenuItem.Checked || продажиToolStripMenuItem.Checked)
            {
                labelMainInfo2.Text = labelMainInfo3.Text = labelMainInfo4.Text = string.Empty;
            }

            if (покупателиToolStripMenuItem.Checked)
            {
                labelMainInfo2.Text = "Всего совершено покупок: " + Main_form.CountingMainParametrs.GetCountOfSaleProduct(dataGridView1);
                labelMainInfo3.Text = "Сумма от продаж: " + Main_form.CountingMainParametrs.GetSumOfSales(dataGridView1);
                labelMainInfo4.Text = string.Empty;
            }

            if (торговаяТочкаToolStripMenuItem.Checked)
            {
                labelMainInfo2.Text = "Объема продаж к числу торговых залов: " + Main_form.CountingMainParametrs.GetVDivOnCountOfPlaces(dataGridView1);
                labelMainInfo3.Text = "Рентабельность: " + Main_form.CountingMainParametrs.GetProfitability(dataGridView1);
                labelMainInfo4.Text = "Товарооборот: " + Main_form.CountingMainParametrs.GetTurnover(dataGridView1);
            }

            if (продавцыToolStripMenuItem.Checked)
            {
                labelMainInfo2.Text = "Всего оклад: " + Main_form.CountingMainParametrs.GetAllSalary(dataGridView1);
                labelMainInfo3.Text = labelMainInfo4.Text = string.Empty;
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

        private void Worker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void продавцыToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            textBoxChsFrom.Enabled = textBoxChsTo.Enabled = textBoxValToSearch.Enabled = buttonPrint.Enabled = buttonSaveInWord.Enabled = buttonSendEmail.Enabled = true;
            textBoxChsTo.Text = textBoxValToSearch.Text = textBoxChsFrom.Text = string.Empty;
            comboBoxSearchBy.Enabled = comboBoxSrchRange.Enabled = true;
            dataGridView1.ReadOnly = true;
            searchString = searchRange = null;
            listBoxStatement.Items.Clear();
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

        private void linkLabelChangeAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("TradeOrgCon.exe");
            this.Close();
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValToSearch.Clear();
        }

        private void comboBoxSrchRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxChsFrom.Clear();
            textBoxChsTo.Clear();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
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

        private void buttonChangeFont_Click(object sender, EventArgs e)
        {
            if (buttonChangeFont.Text == "Увеличить")
            {
                groupBoxMainData.Font = buttonPrint.Font = buttonSaveInWord.Font = buttonSendEmail.Font = listBoxStatement.Font = new Font("Consolas", 12);
                buttonSendEmail.Font = new Font("Consolas", 11);
                groupBoxChsDataBy.Font = groupBoxSearch.Font = dataGridView1.Font = new Font("Consolas", 13);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 9);
                dataGridView1.AutoResizeColumns();
                comboBoxSearchBy.Font = comboBoxSrchRange.Font = textBoxChsFrom.Font = textBoxChsTo.Font = textBoxValToSearch.Font = new Font("Consolas", 14);
            }
            else
            {
                buttonPrint.Font = buttonSaveInWord.Font = buttonSendEmail.Font = listBoxStatement.Font = new Font("Consolas", 10);
                groupBoxChsDataBy.Font = groupBoxSearch.Font = new Font("Consolas", 12);
                dataGridView1.Font = dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10);
                dataGridView1.AutoResizeColumns();
                groupBoxMainData.Font = new Font("Consolas", 11);
                comboBoxSearchBy.Font = comboBoxSrchRange.Font = textBoxChsFrom.Font = textBoxChsTo.Font = textBoxValToSearch.Font = new Font("Consolas", 12);

            }

            buttonChangeFont.Text = buttonChangeFont.Text == "Увеличить" ? "Уменьшить" : "Увеличить";
        }
    }
}
