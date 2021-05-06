namespace TradeOrgCon.AddForm
{
    partial class AddRequestForm
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
            this.maskedTextBoxDateOfSupply = new System.Windows.Forms.MaskedTextBox();
            this.labelSupplierId = new System.Windows.Forms.Label();
            this.comboBoxSuppliertId = new System.Windows.Forms.ComboBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelDateOfSupply = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxProductId = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelToday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBoxDateOfSupply
            // 
            this.maskedTextBoxDateOfSupply.BackColor = System.Drawing.Color.AliceBlue;
            this.maskedTextBoxDateOfSupply.Location = new System.Drawing.Point(124, 22);
            this.maskedTextBoxDateOfSupply.Mask = "00/00/0000";
            this.maskedTextBoxDateOfSupply.Name = "maskedTextBoxDateOfSupply";
            this.maskedTextBoxDateOfSupply.Size = new System.Drawing.Size(184, 26);
            this.maskedTextBoxDateOfSupply.TabIndex = 0;
            this.maskedTextBoxDateOfSupply.ValidatingType = typeof(System.DateTime);
            // 
            // labelSupplierId
            // 
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Location = new System.Drawing.Point(10, 93);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(108, 38);
            this.labelSupplierId.TabIndex = 45;
            this.labelSupplierId.Text = "Код\r\nпоставщика:";
            // 
            // comboBoxSuppliertId
            // 
            this.comboBoxSuppliertId.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxSuppliertId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliertId.FormattingEnabled = true;
            this.comboBoxSuppliertId.Items.AddRange(new object[] {
            "Фирма",
            "Дилер"});
            this.comboBoxSuppliertId.Location = new System.Drawing.Point(124, 104);
            this.comboBoxSuppliertId.Name = "comboBoxSuppliertId";
            this.comboBoxSuppliertId.Size = new System.Drawing.Size(184, 27);
            this.comboBoxSuppliertId.TabIndex = 2;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(10, 144);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(108, 19);
            this.labelCount.TabIndex = 41;
            this.labelCount.Text = "Количество:";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(10, 61);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(108, 19);
            this.labelProductId.TabIndex = 40;
            this.labelProductId.Text = "Код товара:";
            // 
            // labelDateOfSupply
            // 
            this.labelDateOfSupply.AutoSize = true;
            this.labelDateOfSupply.Location = new System.Drawing.Point(10, 10);
            this.labelDateOfSupply.Name = "labelDateOfSupply";
            this.labelDateOfSupply.Size = new System.Drawing.Size(72, 38);
            this.labelDateOfSupply.TabIndex = 39;
            this.labelDateOfSupply.Text = "Дата\r\nзаявки:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancel.Location = new System.Drawing.Point(216, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 34);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdd.Location = new System.Drawing.Point(102, 205);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 34);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxProductId
            // 
            this.comboBoxProductId.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductId.FormattingEnabled = true;
            this.comboBoxProductId.Items.AddRange(new object[] {
            "Фирма",
            "Дилер"});
            this.comboBoxProductId.Location = new System.Drawing.Point(124, 58);
            this.comboBoxProductId.Name = "comboBoxProductId";
            this.comboBoxProductId.Size = new System.Drawing.Size(184, 27);
            this.comboBoxProductId.TabIndex = 1;
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxCount.Location = new System.Drawing.Point(124, 141);
            this.textBoxCount.MaxLength = 8;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(184, 26);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.BackColor = System.Drawing.Color.AliceBlue;
            this.labelToday.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToday.Location = new System.Drawing.Point(248, 28);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(56, 15);
            this.labelToday.TabIndex = 46;
            this.labelToday.Text = "Сегодня";
            this.labelToday.Click += new System.EventHandler(this.labelToday_Click);
            // 
            // AddRequestForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(336, 251);
            this.ControlBox = false;
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxProductId);
            this.Controls.Add(this.maskedTextBoxDateOfSupply);
            this.Controls.Add(this.labelSupplierId);
            this.Controls.Add(this.comboBoxSuppliertId);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.labelDateOfSupply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление заявки";
            this.Load += new System.EventHandler(this.AddRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateOfSupply;
        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.ComboBox comboBoxSuppliertId;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelDateOfSupply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxProductId;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelToday;
    }
}