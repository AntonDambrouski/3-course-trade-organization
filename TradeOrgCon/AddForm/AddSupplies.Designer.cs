namespace TradeOrgCon.AddForm
{
    partial class AddSuppliesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSuppliesForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNameOrg = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxNameOrg = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdd.Location = new System.Drawing.Point(98, 174);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 34);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancel.Location = new System.Drawing.Point(212, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 34);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNameOrg
            // 
            this.labelNameOrg.AutoSize = true;
            this.labelNameOrg.Location = new System.Drawing.Point(12, 9);
            this.labelNameOrg.Name = "labelNameOrg";
            this.labelNameOrg.Size = new System.Drawing.Size(117, 38);
            this.labelNameOrg.TabIndex = 2;
            this.labelNameOrg.Text = "Наименование\r\nпоставщика:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(12, 59);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(63, 19);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 90);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(81, 19);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 121);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(99, 19);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Категория:";
            // 
            // textBoxNameOrg
            // 
            this.textBoxNameOrg.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxNameOrg.Location = new System.Drawing.Point(135, 21);
            this.textBoxNameOrg.Name = "textBoxNameOrg";
            this.textBoxNameOrg.Size = new System.Drawing.Size(184, 26);
            this.textBoxNameOrg.TabIndex = 0;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxAdress.Location = new System.Drawing.Point(135, 56);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(184, 26);
            this.textBoxAdress.TabIndex = 1;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(135, 87);
            this.maskedTextBoxPhone.Mask = "+375-00-000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(184, 26);
            this.maskedTextBoxPhone.TabIndex = 2;
            this.maskedTextBoxPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Фирма",
            "Дилер"});
            this.comboBoxCategory.Location = new System.Drawing.Point(135, 118);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(184, 27);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // AddSuppliesForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(328, 220);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxNameOrg);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelNameOrg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddSuppliesForm";
            this.Text = "Добавить поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNameOrg;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxNameOrg;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}