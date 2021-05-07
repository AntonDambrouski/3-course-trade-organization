namespace TradeOrgCon.AddForm
{
    partial class AddSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSalesForm));
            this.comboBoxClientId = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelDateOfSale = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelClientId = new System.Windows.Forms.Label();
            this.labelSellerId = new System.Windows.Forms.Label();
            this.comboBoxSellerId = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDateOfSales = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxProductId = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.linkLabelAddClient = new System.Windows.Forms.LinkLabel();
            this.labelToday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxClientId
            // 
            this.comboBoxClientId.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientId.FormattingEnabled = true;
            this.comboBoxClientId.Items.AddRange(new object[] {
            "Фирма",
            "Дилер"});
            this.comboBoxClientId.Location = new System.Drawing.Point(125, 183);
            this.comboBoxClientId.Name = "comboBoxClientId";
            this.comboBoxClientId.Size = new System.Drawing.Size(184, 27);
            this.comboBoxClientId.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(11, 136);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 19);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Цена:\r\n";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(11, 100);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(108, 19);
            this.labelCount.TabIndex = 25;
            this.labelCount.Text = "Количество:";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(11, 64);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(108, 19);
            this.labelProductId.TabIndex = 24;
            this.labelProductId.Text = "Код товара:";
            // 
            // labelDateOfSale
            // 
            this.labelDateOfSale.AutoSize = true;
            this.labelDateOfSale.Location = new System.Drawing.Point(11, 9);
            this.labelDateOfSale.Name = "labelDateOfSale";
            this.labelDateOfSale.Size = new System.Drawing.Size(81, 38);
            this.labelDateOfSale.TabIndex = 23;
            this.labelDateOfSale.Text = "Дата\r\nпокупки:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancel.Location = new System.Drawing.Point(210, 348);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 34);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdd.Location = new System.Drawing.Point(96, 348);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 34);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(11, 172);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(108, 38);
            this.labelClientId.TabIndex = 31;
            this.labelClientId.Text = "Код\r\nпокупателя:";
            // 
            // labelSellerId
            // 
            this.labelSellerId.AutoSize = true;
            this.labelSellerId.Location = new System.Drawing.Point(11, 255);
            this.labelSellerId.Name = "labelSellerId";
            this.labelSellerId.Size = new System.Drawing.Size(90, 38);
            this.labelSellerId.TabIndex = 33;
            this.labelSellerId.Text = "Код\r\nпродавца:";
            // 
            // comboBoxSellerId
            // 
            this.comboBoxSellerId.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxSellerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSellerId.FormattingEnabled = true;
            this.comboBoxSellerId.Items.AddRange(new object[] {
            "Фирма",
            "Дилер"});
            this.comboBoxSellerId.Location = new System.Drawing.Point(125, 266);
            this.comboBoxSellerId.Name = "comboBoxSellerId";
            this.comboBoxSellerId.Size = new System.Drawing.Size(184, 27);
            this.comboBoxSellerId.TabIndex = 6;
            // 
            // maskedTextBoxDateOfSales
            // 
            this.maskedTextBoxDateOfSales.BackColor = System.Drawing.Color.AliceBlue;
            this.maskedTextBoxDateOfSales.Location = new System.Drawing.Point(125, 21);
            this.maskedTextBoxDateOfSales.Mask = "00/00/0000";
            this.maskedTextBoxDateOfSales.Name = "maskedTextBoxDateOfSales";
            this.maskedTextBoxDateOfSales.Size = new System.Drawing.Size(184, 26);
            this.maskedTextBoxDateOfSales.TabIndex = 0;
            this.maskedTextBoxDateOfSales.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxProductId
            // 
            this.comboBoxProductId.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductId.FormattingEnabled = true;
            this.comboBoxProductId.Items.AddRange(new object[] {
            "Фирма",
            "Дилер"});
            this.comboBoxProductId.Location = new System.Drawing.Point(125, 61);
            this.comboBoxProductId.Name = "comboBoxProductId";
            this.comboBoxProductId.Size = new System.Drawing.Size(184, 27);
            this.comboBoxProductId.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxCount.Location = new System.Drawing.Point(125, 97);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(184, 26);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxPrice.Location = new System.Drawing.Point(125, 133);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(184, 26);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // linkLabelAddClient
            // 
            this.linkLabelAddClient.AutoSize = true;
            this.linkLabelAddClient.Location = new System.Drawing.Point(24, 213);
            this.linkLabelAddClient.Name = "linkLabelAddClient";
            this.linkLabelAddClient.Size = new System.Drawing.Size(180, 19);
            this.linkLabelAddClient.TabIndex = 34;
            this.linkLabelAddClient.TabStop = true;
            this.linkLabelAddClient.Text = "Добавить покупателя";
            this.linkLabelAddClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddClient_LinkClicked);
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.BackColor = System.Drawing.Color.AliceBlue;
            this.labelToday.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToday.Location = new System.Drawing.Point(248, 27);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(56, 15);
            this.labelToday.TabIndex = 35;
            this.labelToday.Text = "Сегодня";
            this.labelToday.Click += new System.EventHandler(this.labelToday_Click);
            // 
            // AddSalesForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(330, 394);
            this.ControlBox = false;
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.linkLabelAddClient);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxProductId);
            this.Controls.Add(this.maskedTextBoxDateOfSales);
            this.Controls.Add(this.comboBoxSellerId);
            this.Controls.Add(this.labelSellerId);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.comboBoxClientId);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.labelDateOfSale);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление продажи";
            this.Load += new System.EventHandler(this.AddSalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClientId;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelDateOfSale;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelSellerId;
        private System.Windows.Forms.ComboBox comboBoxSellerId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateOfSales;
        private System.Windows.Forms.ComboBox comboBoxProductId;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.LinkLabel linkLabelAddClient;
        private System.Windows.Forms.Label labelToday;
    }
}