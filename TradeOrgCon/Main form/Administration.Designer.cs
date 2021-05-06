namespace TradeOrgCon.Main_form
{
    partial class Administration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.panelWorkSpace = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавциToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTradOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStore = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учётныеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInstruments = new System.Windows.Forms.Panel();
            this.groupBoxChsDataBy = new System.Windows.Forms.GroupBox();
            this.ErrorChsLabel = new System.Windows.Forms.Label();
            this.textBoxChsTo = new System.Windows.Forms.TextBox();
            this.labelChsTo = new System.Windows.Forms.Label();
            this.textBoxChsFrom = new System.Windows.Forms.TextBox();
            this.labelChsFrom = new System.Windows.Forms.Label();
            this.comboBoxSrchRange = new System.Windows.Forms.ComboBox();
            this.labelSearchByRange = new System.Windows.Forms.Label();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSaveInWord = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.ErrorSearchInputlabel = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxValToSearch = new System.Windows.Forms.TextBox();
            this.labelSearchValue = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.linkLabelChangeAccount = new System.Windows.Forms.LinkLabel();
            this.panelWorkSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelInstruments.SuspendLayout();
            this.groupBoxChsDataBy.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkSpace
            // 
            this.panelWorkSpace.BackColor = System.Drawing.Color.AliceBlue;
            this.panelWorkSpace.Controls.Add(this.dataGridView1);
            this.panelWorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelWorkSpace.Location = new System.Drawing.Point(142, 0);
            this.panelWorkSpace.Name = "panelWorkSpace";
            this.panelWorkSpace.Size = new System.Drawing.Size(1042, 662);
            this.panelWorkSpace.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикиToolStripMenuItem,
            this.продавциToolStripMenuItem,
            this.заявкиToolStripMenuItem,
            this.toolStripMenuItemTradOrganization,
            this.toolStripMenuItemStore,
            this.продажиToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.учётныеЗаписиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(142, 662);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.поставщикиToolStripMenuItem.CheckOnClick = true;
            this.поставщикиToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поставщикиToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // продавциToolStripMenuItem
            // 
            this.продавциToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.продавциToolStripMenuItem.CheckOnClick = true;
            this.продавциToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.продавциToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.продавциToolStripMenuItem.Name = "продавциToolStripMenuItem";
            this.продавциToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.продавциToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.продавциToolStripMenuItem.Text = "Продавцы";
            this.продавциToolStripMenuItem.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.продавциToolStripMenuItem.Click += new System.EventHandler(this.продавциToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.заявкиToolStripMenuItem.CheckOnClick = true;
            this.заявкиToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.заявкиToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItemTradOrganization
            // 
            this.toolStripMenuItemTradOrganization.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenuItemTradOrganization.CheckOnClick = true;
            this.toolStripMenuItemTradOrganization.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItemTradOrganization.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.toolStripMenuItemTradOrganization.Name = "toolStripMenuItemTradOrganization";
            this.toolStripMenuItemTradOrganization.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripMenuItemTradOrganization.Size = new System.Drawing.Size(135, 43);
            this.toolStripMenuItemTradOrganization.Text = "Торговая точка";
            this.toolStripMenuItemTradOrganization.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.toolStripMenuItemTradOrganization.Click += new System.EventHandler(this.toolStripMenuItemTradOrganization_Click);
            // 
            // toolStripMenuItemStore
            // 
            this.toolStripMenuItemStore.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenuItemStore.CheckOnClick = true;
            this.toolStripMenuItemStore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItemStore.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.toolStripMenuItemStore.Name = "toolStripMenuItemStore";
            this.toolStripMenuItemStore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripMenuItemStore.Size = new System.Drawing.Size(135, 43);
            this.toolStripMenuItemStore.Text = "Склад";
            this.toolStripMenuItemStore.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.toolStripMenuItemStore.Click += new System.EventHandler(this.toolStripMenuItemStore_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.продажиToolStripMenuItem.CheckOnClick = true;
            this.продажиToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.продажиToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.покупателиToolStripMenuItem.CheckOnClick = true;
            this.покупателиToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.покупателиToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // учётныеЗаписиToolStripMenuItem
            // 
            this.учётныеЗаписиToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.учётныеЗаписиToolStripMenuItem.CheckOnClick = true;
            this.учётныеЗаписиToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.учётныеЗаписиToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.учётныеЗаписиToolStripMenuItem.Name = "учётныеЗаписиToolStripMenuItem";
            this.учётныеЗаписиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.учётныеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.учётныеЗаписиToolStripMenuItem.Text = "Учётные записи";
            this.учётныеЗаписиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.поставщикиToolStripMenuItem_CheckedChanged);
            this.учётныеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.учётныеЗаписиToolStripMenuItem_Click);
            // 
            // panelInstruments
            // 
            this.panelInstruments.BackColor = System.Drawing.Color.LightGreen;
            this.panelInstruments.Controls.Add(this.groupBoxChsDataBy);
            this.panelInstruments.Controls.Add(this.buttonSendEmail);
            this.panelInstruments.Controls.Add(this.buttonPrint);
            this.panelInstruments.Controls.Add(this.buttonSaveInWord);
            this.panelInstruments.Controls.Add(this.buttonDel);
            this.panelInstruments.Controls.Add(this.buttonAdd);
            this.panelInstruments.Controls.Add(this.groupBoxSearch);
            this.panelInstruments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInstruments.Location = new System.Drawing.Point(142, 481);
            this.panelInstruments.Name = "panelInstruments";
            this.panelInstruments.Size = new System.Drawing.Size(1042, 181);
            this.panelInstruments.TabIndex = 2;
            // 
            // groupBoxChsDataBy
            // 
            this.groupBoxChsDataBy.Controls.Add(this.ErrorChsLabel);
            this.groupBoxChsDataBy.Controls.Add(this.textBoxChsTo);
            this.groupBoxChsDataBy.Controls.Add(this.labelChsTo);
            this.groupBoxChsDataBy.Controls.Add(this.textBoxChsFrom);
            this.groupBoxChsDataBy.Controls.Add(this.labelChsFrom);
            this.groupBoxChsDataBy.Controls.Add(this.comboBoxSrchRange);
            this.groupBoxChsDataBy.Controls.Add(this.labelSearchByRange);
            this.groupBoxChsDataBy.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChsDataBy.Location = new System.Drawing.Point(577, 3);
            this.groupBoxChsDataBy.Name = "groupBoxChsDataBy";
            this.groupBoxChsDataBy.Size = new System.Drawing.Size(453, 169);
            this.groupBoxChsDataBy.TabIndex = 6;
            this.groupBoxChsDataBy.TabStop = false;
            this.groupBoxChsDataBy.Text = "Критерий выборки данных";
            // 
            // ErrorChsLabel
            // 
            this.ErrorChsLabel.AutoSize = true;
            this.ErrorChsLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ErrorChsLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorChsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorChsLabel.Location = new System.Drawing.Point(65, 96);
            this.ErrorChsLabel.Name = "ErrorChsLabel";
            this.ErrorChsLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorChsLabel.TabIndex = 5;
            // 
            // textBoxChsTo
            // 
            this.textBoxChsTo.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxChsTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChsTo.Enabled = false;
            this.textBoxChsTo.Location = new System.Drawing.Point(196, 67);
            this.textBoxChsTo.Name = "textBoxChsTo";
            this.textBoxChsTo.Size = new System.Drawing.Size(100, 25);
            this.textBoxChsTo.TabIndex = 8;
            this.textBoxChsTo.EnabledChanged += new System.EventHandler(this.textBoxChsFrom_EnabledChanged);
            this.textBoxChsTo.TextChanged += new System.EventHandler(this.textBoxChsFrom_TextChanged);
            // 
            // labelChsTo
            // 
            this.labelChsTo.AutoSize = true;
            this.labelChsTo.Location = new System.Drawing.Point(158, 70);
            this.labelChsTo.Name = "labelChsTo";
            this.labelChsTo.Size = new System.Drawing.Size(32, 18);
            this.labelChsTo.TabIndex = 7;
            this.labelChsTo.Text = "До:";
            // 
            // textBoxChsFrom
            // 
            this.textBoxChsFrom.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxChsFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChsFrom.Enabled = false;
            this.textBoxChsFrom.Location = new System.Drawing.Point(44, 66);
            this.textBoxChsFrom.Name = "textBoxChsFrom";
            this.textBoxChsFrom.Size = new System.Drawing.Size(100, 25);
            this.textBoxChsFrom.TabIndex = 6;
            this.textBoxChsFrom.EnabledChanged += new System.EventHandler(this.textBoxChsFrom_EnabledChanged);
            this.textBoxChsFrom.TextChanged += new System.EventHandler(this.textBoxChsFrom_TextChanged);
            // 
            // labelChsFrom
            // 
            this.labelChsFrom.AutoSize = true;
            this.labelChsFrom.Location = new System.Drawing.Point(6, 69);
            this.labelChsFrom.Name = "labelChsFrom";
            this.labelChsFrom.Size = new System.Drawing.Size(32, 18);
            this.labelChsFrom.TabIndex = 5;
            this.labelChsFrom.Text = "От:";
            // 
            // comboBoxSrchRange
            // 
            this.comboBoxSrchRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSrchRange.FormattingEnabled = true;
            this.comboBoxSrchRange.Location = new System.Drawing.Point(92, 29);
            this.comboBoxSrchRange.Name = "comboBoxSrchRange";
            this.comboBoxSrchRange.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSrchRange.TabIndex = 4;
            this.comboBoxSrchRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxSrchRange_SelectedIndexChanged);
            this.comboBoxSrchRange.EnabledChanged += new System.EventHandler(this.textBoxChsFrom_EnabledChanged);
            // 
            // labelSearchByRange
            // 
            this.labelSearchByRange.AutoSize = true;
            this.labelSearchByRange.Location = new System.Drawing.Point(6, 32);
            this.labelSearchByRange.Name = "labelSearchByRange";
            this.labelSearchByRange.Size = new System.Drawing.Size(80, 18);
            this.labelSearchByRange.TabIndex = 0;
            this.labelSearchByRange.Text = "Поиск по:";
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSendEmail.Enabled = false;
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendEmail.Location = new System.Drawing.Point(3, 143);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(155, 29);
            this.buttonSendEmail.TabIndex = 5;
            this.buttonSendEmail.Text = "Отправить на email";
            this.buttonSendEmail.UseVisualStyleBackColor = false;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPrint.Enabled = false;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Location = new System.Drawing.Point(3, 108);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(155, 29);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSaveInWord
            // 
            this.buttonSaveInWord.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSaveInWord.Enabled = false;
            this.buttonSaveInWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveInWord.Location = new System.Drawing.Point(3, 73);
            this.buttonSaveInWord.Name = "buttonSaveInWord";
            this.buttonSaveInWord.Size = new System.Drawing.Size(155, 29);
            this.buttonSaveInWord.TabIndex = 3;
            this.buttonSaveInWord.Text = "Сохранить в word";
            this.buttonSaveInWord.UseVisualStyleBackColor = false;
            this.buttonSaveInWord.Click += new System.EventHandler(this.buttonSaveInWord_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonDel.Enabled = false;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(3, 38);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(155, 29);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.ErrorSearchInputlabel);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchBy);
            this.groupBoxSearch.Controls.Add(this.textBoxValToSearch);
            this.groupBoxSearch.Controls.Add(this.labelSearchValue);
            this.groupBoxSearch.Controls.Add(this.labelSearchBy);
            this.groupBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch.Location = new System.Drawing.Point(179, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(392, 169);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // ErrorSearchInputlabel
            // 
            this.ErrorSearchInputlabel.AutoSize = true;
            this.ErrorSearchInputlabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ErrorSearchInputlabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorSearchInputlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorSearchInputlabel.Location = new System.Drawing.Point(20, 96);
            this.ErrorSearchInputlabel.Name = "ErrorSearchInputlabel";
            this.ErrorSearchInputlabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorSearchInputlabel.TabIndex = 4;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Location = new System.Drawing.Point(102, 32);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(149, 27);
            this.comboBoxSearchBy.Sorted = true;
            this.comboBoxSearchBy.TabIndex = 3;
            this.comboBoxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBy_SelectedIndexChanged);
            // 
            // textBoxValToSearch
            // 
            this.textBoxValToSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxValToSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValToSearch.Enabled = false;
            this.textBoxValToSearch.Location = new System.Drawing.Point(102, 67);
            this.textBoxValToSearch.Name = "textBoxValToSearch";
            this.textBoxValToSearch.Size = new System.Drawing.Size(149, 26);
            this.textBoxValToSearch.TabIndex = 2;
            this.textBoxValToSearch.TextChanged += new System.EventHandler(this.textBoxValToSearch_TextChanged);
            // 
            // labelSearchValue
            // 
            this.labelSearchValue.AutoSize = true;
            this.labelSearchValue.Location = new System.Drawing.Point(6, 69);
            this.labelSearchValue.Name = "labelSearchValue";
            this.labelSearchValue.Size = new System.Drawing.Size(90, 19);
            this.labelSearchValue.TabIndex = 1;
            this.labelSearchValue.Text = "Значение:";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(6, 35);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(90, 19);
            this.labelSearchBy.TabIndex = 0;
            this.labelSearchBy.Text = "Поиск по:";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument;
            this.printDialog1.UseEXDialog = true;
            // 
            // linkLabelChangeAccount
            // 
            this.linkLabelChangeAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelChangeAccount.AutoSize = true;
            this.linkLabelChangeAccount.BackColor = System.Drawing.Color.AliceBlue;
            this.linkLabelChangeAccount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelChangeAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelChangeAccount.Location = new System.Drawing.Point(8, 639);
            this.linkLabelChangeAccount.Name = "linkLabelChangeAccount";
            this.linkLabelChangeAccount.Size = new System.Drawing.Size(127, 13);
            this.linkLabelChangeAccount.TabIndex = 5;
            this.linkLabelChangeAccount.TabStop = true;
            this.linkLabelChangeAccount.Text = "Сменить пользователя";
            this.linkLabelChangeAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangeAccount_LinkClicked);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.linkLabelChangeAccount);
            this.Controls.Add(this.panelInstruments);
            this.Controls.Add(this.panelWorkSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administration";
            this.Text = "Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administration_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Administration_ResizeEnd);
            this.panelWorkSpace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInstruments.ResumeLayout(false);
            this.groupBoxChsDataBy.ResumeLayout(false);
            this.groupBoxChsDataBy.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWorkSpace;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавциToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTradOrganization;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStore;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.Panel panelInstruments;
        private System.Windows.Forms.Button buttonSendEmail;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSaveInWord;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxChsDataBy;
        private System.Windows.Forms.Label ErrorSearchInputlabel;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBoxValToSearch;
        private System.Windows.Forms.Label labelSearchValue;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Label labelSearchByRange;
        private System.Windows.Forms.Label ErrorChsLabel;
        private System.Windows.Forms.TextBox textBoxChsTo;
        private System.Windows.Forms.Label labelChsTo;
        private System.Windows.Forms.TextBox textBoxChsFrom;
        private System.Windows.Forms.Label labelChsFrom;
        private System.Windows.Forms.ComboBox comboBoxSrchRange;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripMenuItem учётныеЗаписиToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.LinkLabel linkLabelChangeAccount;
    }
}