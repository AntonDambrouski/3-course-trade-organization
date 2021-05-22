namespace TradeOrgCon.Main_form
{
    partial class Worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worker));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.торговаяТочкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMainData = new System.Windows.Forms.GroupBox();
            this.labelMainInfo4 = new System.Windows.Forms.Label();
            this.labelMainInfo3 = new System.Windows.Forms.Label();
            this.labelMainInfo2 = new System.Windows.Forms.Label();
            this.labelMainInfo1 = new System.Windows.Forms.Label();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSaveInWord = new System.Windows.Forms.Button();
            this.groupBoxChsDataBy = new System.Windows.Forms.GroupBox();
            this.ErrorChsLabel = new System.Windows.Forms.Label();
            this.textBoxChsTo = new System.Windows.Forms.TextBox();
            this.labelChsTo = new System.Windows.Forms.Label();
            this.textBoxChsFrom = new System.Windows.Forms.TextBox();
            this.labelChsFrom = new System.Windows.Forms.Label();
            this.comboBoxSrchRange = new System.Windows.Forms.ComboBox();
            this.labelSearchByRange = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.listBoxStatement = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelStatement = new System.Windows.Forms.Button();
            this.buttonAddStatement = new System.Windows.Forms.Button();
            this.ErrorSearchInputlabel = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.labelSearchValue = new System.Windows.Forms.Label();
            this.textBoxValToSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.linkLabelChangeAccount = new System.Windows.Forms.LinkLabel();
            this.buttonAboutProgram = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonChangeFont = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMainData.SuspendLayout();
            this.groupBoxChsDataBy.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикиToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.торговаяТочкаToolStripMenuItem,
            this.продавцыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(142, 711);
            this.menuStrip1.TabIndex = 0;
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
            this.поставщикиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.продавцыToolStripMenuItem_CheckedChanged);
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
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
            this.продажиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.продавцыToolStripMenuItem_CheckedChanged);
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
            this.покупателиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.продавцыToolStripMenuItem_CheckedChanged);
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // торговаяТочкаToolStripMenuItem
            // 
            this.торговаяТочкаToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.торговаяТочкаToolStripMenuItem.CheckOnClick = true;
            this.торговаяТочкаToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.торговаяТочкаToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.торговаяТочкаToolStripMenuItem.Name = "торговаяТочкаToolStripMenuItem";
            this.торговаяТочкаToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.торговаяТочкаToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.торговаяТочкаToolStripMenuItem.Text = "Торговая точка";
            this.торговаяТочкаToolStripMenuItem.CheckedChanged += new System.EventHandler(this.продавцыToolStripMenuItem_CheckedChanged);
            this.торговаяТочкаToolStripMenuItem.Click += new System.EventHandler(this.торговаяТочкаToolStripMenuItem_Click);
            // 
            // продавцыToolStripMenuItem
            // 
            this.продавцыToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.продавцыToolStripMenuItem.CheckOnClick = true;
            this.продавцыToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.продавцыToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.продавцыToolStripMenuItem.Name = "продавцыToolStripMenuItem";
            this.продавцыToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.продавцыToolStripMenuItem.Size = new System.Drawing.Size(135, 43);
            this.продавцыToolStripMenuItem.Text = "Продавцы";
            this.продавцыToolStripMenuItem.CheckedChanged += new System.EventHandler(this.продавцыToolStripMenuItem_CheckedChanged);
            this.продавцыToolStripMenuItem.Click += new System.EventHandler(this.продавцыToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.groupBoxMainData);
            this.panel1.Controls.Add(this.buttonSendEmail);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonSaveInWord);
            this.panel1.Controls.Add(this.groupBoxChsDataBy);
            this.panel1.Controls.Add(this.groupBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(142, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 220);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxMainData
            // 
            this.groupBoxMainData.Controls.Add(this.labelMainInfo4);
            this.groupBoxMainData.Controls.Add(this.labelMainInfo3);
            this.groupBoxMainData.Controls.Add(this.labelMainInfo2);
            this.groupBoxMainData.Controls.Add(this.labelMainInfo1);
            this.groupBoxMainData.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMainData.Location = new System.Drawing.Point(3, 6);
            this.groupBoxMainData.Name = "groupBoxMainData";
            this.groupBoxMainData.Size = new System.Drawing.Size(470, 100);
            this.groupBoxMainData.TabIndex = 12;
            this.groupBoxMainData.TabStop = false;
            this.groupBoxMainData.Text = "Основные показатели";
            // 
            // labelMainInfo4
            // 
            this.labelMainInfo4.AutoSize = true;
            this.labelMainInfo4.Location = new System.Drawing.Point(6, 80);
            this.labelMainInfo4.Name = "labelMainInfo4";
            this.labelMainInfo4.Size = new System.Drawing.Size(0, 18);
            this.labelMainInfo4.TabIndex = 3;
            // 
            // labelMainInfo3
            // 
            this.labelMainInfo3.AutoSize = true;
            this.labelMainInfo3.Location = new System.Drawing.Point(6, 62);
            this.labelMainInfo3.Name = "labelMainInfo3";
            this.labelMainInfo3.Size = new System.Drawing.Size(0, 18);
            this.labelMainInfo3.TabIndex = 2;
            // 
            // labelMainInfo2
            // 
            this.labelMainInfo2.AutoSize = true;
            this.labelMainInfo2.Location = new System.Drawing.Point(6, 44);
            this.labelMainInfo2.Name = "labelMainInfo2";
            this.labelMainInfo2.Size = new System.Drawing.Size(0, 18);
            this.labelMainInfo2.TabIndex = 1;
            // 
            // labelMainInfo1
            // 
            this.labelMainInfo1.AutoSize = true;
            this.labelMainInfo1.Location = new System.Drawing.Point(6, 26);
            this.labelMainInfo1.Name = "labelMainInfo1";
            this.labelMainInfo1.Size = new System.Drawing.Size(0, 18);
            this.labelMainInfo1.TabIndex = 0;
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSendEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSendEmail.Enabled = false;
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendEmail.Location = new System.Drawing.Point(12, 183);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(165, 29);
            this.buttonSendEmail.TabIndex = 11;
            this.buttonSendEmail.Text = "Отправить на email";
            this.buttonSendEmail.UseVisualStyleBackColor = false;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPrint.Enabled = false;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(12, 148);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(165, 29);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSaveInWord
            // 
            this.buttonSaveInWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveInWord.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSaveInWord.Enabled = false;
            this.buttonSaveInWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveInWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveInWord.Location = new System.Drawing.Point(12, 113);
            this.buttonSaveInWord.Name = "buttonSaveInWord";
            this.buttonSaveInWord.Size = new System.Drawing.Size(165, 29);
            this.buttonSaveInWord.TabIndex = 9;
            this.buttonSaveInWord.Text = "Сохранить в word";
            this.buttonSaveInWord.UseVisualStyleBackColor = false;
            this.buttonSaveInWord.Click += new System.EventHandler(this.buttonSaveInWord_Click);
            // 
            // groupBoxChsDataBy
            // 
            this.groupBoxChsDataBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChsDataBy.Controls.Add(this.ErrorChsLabel);
            this.groupBoxChsDataBy.Controls.Add(this.textBoxChsTo);
            this.groupBoxChsDataBy.Controls.Add(this.labelChsTo);
            this.groupBoxChsDataBy.Controls.Add(this.textBoxChsFrom);
            this.groupBoxChsDataBy.Controls.Add(this.labelChsFrom);
            this.groupBoxChsDataBy.Controls.Add(this.comboBoxSrchRange);
            this.groupBoxChsDataBy.Controls.Add(this.labelSearchByRange);
            this.groupBoxChsDataBy.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChsDataBy.Location = new System.Drawing.Point(1000, 6);
            this.groupBoxChsDataBy.Name = "groupBoxChsDataBy";
            this.groupBoxChsDataBy.Size = new System.Drawing.Size(330, 211);
            this.groupBoxChsDataBy.TabIndex = 8;
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
            this.textBoxChsTo.Enabled = false;
            this.textBoxChsTo.Location = new System.Drawing.Point(196, 67);
            this.textBoxChsTo.MaxLength = 50;
            this.textBoxChsTo.Name = "textBoxChsTo";
            this.textBoxChsTo.Size = new System.Drawing.Size(100, 25);
            this.textBoxChsTo.TabIndex = 8;
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
            this.textBoxChsFrom.Enabled = false;
            this.textBoxChsFrom.Location = new System.Drawing.Point(44, 66);
            this.textBoxChsFrom.MaxLength = 50;
            this.textBoxChsFrom.Name = "textBoxChsFrom";
            this.textBoxChsFrom.Size = new System.Drawing.Size(100, 25);
            this.textBoxChsFrom.TabIndex = 6;
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
            this.comboBoxSrchRange.Enabled = false;
            this.comboBoxSrchRange.FormattingEnabled = true;
            this.comboBoxSrchRange.Location = new System.Drawing.Point(100, 29);
            this.comboBoxSrchRange.Name = "comboBoxSrchRange";
            this.comboBoxSrchRange.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSrchRange.TabIndex = 4;
            this.comboBoxSrchRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxSrchRange_SelectedIndexChanged);
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
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.listBoxStatement);
            this.groupBoxSearch.Controls.Add(this.button1);
            this.groupBoxSearch.Controls.Add(this.buttonDelStatement);
            this.groupBoxSearch.Controls.Add(this.buttonAddStatement);
            this.groupBoxSearch.Controls.Add(this.ErrorSearchInputlabel);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchBy);
            this.groupBoxSearch.Controls.Add(this.labelSearchBy);
            this.groupBoxSearch.Controls.Add(this.labelSearchValue);
            this.groupBoxSearch.Controls.Add(this.textBoxValToSearch);
            this.groupBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch.Location = new System.Drawing.Point(479, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(515, 211);
            this.groupBoxSearch.TabIndex = 7;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // listBoxStatement
            // 
            this.listBoxStatement.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxStatement.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStatement.FormattingEnabled = true;
            this.listBoxStatement.HorizontalScrollbar = true;
            this.listBoxStatement.ItemHeight = 15;
            this.listBoxStatement.Location = new System.Drawing.Point(254, 18);
            this.listBoxStatement.Name = "listBoxStatement";
            this.listBoxStatement.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStatement.Size = new System.Drawing.Size(255, 184);
            this.listBoxStatement.Sorted = true;
            this.listBoxStatement.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelStatement
            // 
            this.buttonDelStatement.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonDelStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelStatement.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelStatement.Location = new System.Drawing.Point(34, 140);
            this.buttonDelStatement.Name = "buttonDelStatement";
            this.buttonDelStatement.Size = new System.Drawing.Size(173, 30);
            this.buttonDelStatement.TabIndex = 10;
            this.buttonDelStatement.Text = "Удалить условие";
            this.buttonDelStatement.UseVisualStyleBackColor = false;
            this.buttonDelStatement.Click += new System.EventHandler(this.buttonDelStatement_Click);
            // 
            // buttonAddStatement
            // 
            this.buttonAddStatement.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAddStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddStatement.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStatement.Location = new System.Drawing.Point(34, 104);
            this.buttonAddStatement.Name = "buttonAddStatement";
            this.buttonAddStatement.Size = new System.Drawing.Size(173, 30);
            this.buttonAddStatement.TabIndex = 9;
            this.buttonAddStatement.Text = "Добавить условие";
            this.buttonAddStatement.UseVisualStyleBackColor = false;
            this.buttonAddStatement.Click += new System.EventHandler(this.buttonAddStatement_Click);
            // 
            // ErrorSearchInputlabel
            // 
            this.ErrorSearchInputlabel.AutoSize = true;
            this.ErrorSearchInputlabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ErrorSearchInputlabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorSearchInputlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorSearchInputlabel.Location = new System.Drawing.Point(30, 85);
            this.ErrorSearchInputlabel.Name = "ErrorSearchInputlabel";
            this.ErrorSearchInputlabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorSearchInputlabel.TabIndex = 4;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Enabled = false;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Location = new System.Drawing.Point(116, 23);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchBy.TabIndex = 3;
            this.comboBoxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBy_SelectedIndexChanged);
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(6, 26);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(90, 19);
            this.labelSearchBy.TabIndex = 0;
            this.labelSearchBy.Text = "Поиск по:";
            // 
            // labelSearchValue
            // 
            this.labelSearchValue.AutoSize = true;
            this.labelSearchValue.Location = new System.Drawing.Point(6, 60);
            this.labelSearchValue.Name = "labelSearchValue";
            this.labelSearchValue.Size = new System.Drawing.Size(90, 19);
            this.labelSearchValue.TabIndex = 1;
            this.labelSearchValue.Text = "Значение:";
            // 
            // textBoxValToSearch
            // 
            this.textBoxValToSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxValToSearch.Enabled = false;
            this.textBoxValToSearch.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValToSearch.Location = new System.Drawing.Point(116, 58);
            this.textBoxValToSearch.MaxLength = 50;
            this.textBoxValToSearch.Name = "textBoxValToSearch";
            this.textBoxValToSearch.Size = new System.Drawing.Size(121, 25);
            this.textBoxValToSearch.TabIndex = 2;
            this.textBoxValToSearch.TextChanged += new System.EventHandler(this.textBoxValToSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 491);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 490);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument;
            this.printDialog1.UseEXDialog = true;
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
            // linkLabelChangeAccount
            // 
            this.linkLabelChangeAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelChangeAccount.AutoSize = true;
            this.linkLabelChangeAccount.BackColor = System.Drawing.Color.AliceBlue;
            this.linkLabelChangeAccount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelChangeAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelChangeAccount.Location = new System.Drawing.Point(9, 690);
            this.linkLabelChangeAccount.Name = "linkLabelChangeAccount";
            this.linkLabelChangeAccount.Size = new System.Drawing.Size(127, 13);
            this.linkLabelChangeAccount.TabIndex = 4;
            this.linkLabelChangeAccount.TabStop = true;
            this.linkLabelChangeAccount.Text = "Сменить пользователя";
            this.linkLabelChangeAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangeAccount_LinkClicked);
            // 
            // buttonAboutProgram
            // 
            this.buttonAboutProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAboutProgram.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAboutProgram.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboutProgram.Location = new System.Drawing.Point(3, 643);
            this.buttonAboutProgram.Name = "buttonAboutProgram";
            this.buttonAboutProgram.Size = new System.Drawing.Size(135, 30);
            this.buttonAboutProgram.TabIndex = 17;
            this.buttonAboutProgram.Text = "О программе";
            this.buttonAboutProgram.UseVisualStyleBackColor = false;
            this.buttonAboutProgram.Click += new System.EventHandler(this.buttonAboutProgram_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAbout.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAbout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(3, 607);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(135, 30);
            this.buttonAbout.TabIndex = 16;
            this.buttonAbout.Text = "Справка";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeFont.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonChangeFont.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeFont.Location = new System.Drawing.Point(3, 568);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(135, 30);
            this.buttonChangeFont.TabIndex = 15;
            this.buttonChangeFont.Text = "Увеличить";
            this.buttonChangeFont.UseVisualStyleBackColor = false;
            this.buttonChangeFont.Click += new System.EventHandler(this.buttonChangeFont_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.buttonAboutProgram);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonChangeFont);
            this.Controls.Add(this.linkLabelChangeAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Worker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Worker_FormClosing);
            this.Load += new System.EventHandler(this.Worker_Load);
            this.ResizeEnd += new System.EventHandler(this.Worker_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxMainData.ResumeLayout(false);
            this.groupBoxMainData.PerformLayout();
            this.groupBoxChsDataBy.ResumeLayout(false);
            this.groupBoxChsDataBy.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem торговаяТочкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавцыToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxChsDataBy;
        private System.Windows.Forms.Label ErrorChsLabel;
        private System.Windows.Forms.TextBox textBoxChsTo;
        private System.Windows.Forms.Label labelChsTo;
        private System.Windows.Forms.TextBox textBoxChsFrom;
        private System.Windows.Forms.Label labelChsFrom;
        private System.Windows.Forms.ComboBox comboBoxSrchRange;
        private System.Windows.Forms.Label labelSearchByRange;
        private System.Windows.Forms.Button buttonSendEmail;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSaveInWord;
        private System.Windows.Forms.GroupBox groupBoxMainData;
        private System.Windows.Forms.Label labelMainInfo4;
        private System.Windows.Forms.Label labelMainInfo3;
        private System.Windows.Forms.Label labelMainInfo2;
        private System.Windows.Forms.Label labelMainInfo1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.LinkLabel linkLabelChangeAccount;
        private System.Windows.Forms.Button buttonAboutProgram;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonChangeFont;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ListBox listBoxStatement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelStatement;
        private System.Windows.Forms.Button buttonAddStatement;
        private System.Windows.Forms.Label ErrorSearchInputlabel;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Label labelSearchValue;
        private System.Windows.Forms.TextBox textBoxValToSearch;
    }
}