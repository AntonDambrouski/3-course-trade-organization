namespace TradeOrgCon.AddForm
{
    partial class AddOutletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOutletForm));
            this.labelCountOfShppngRoom = new System.Windows.Forms.Label();
            this.labelTypeOfShppngRoom = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxTupeOfShppngRoom = new System.Windows.Forms.ComboBox();
            this.textBoxCountOfPlace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCountOfShppngRoom
            // 
            this.labelCountOfShppngRoom.AutoSize = true;
            this.labelCountOfShppngRoom.Location = new System.Drawing.Point(12, 64);
            this.labelCountOfShppngRoom.Name = "labelCountOfShppngRoom";
            this.labelCountOfShppngRoom.Size = new System.Drawing.Size(144, 38);
            this.labelCountOfShppngRoom.TabIndex = 23;
            this.labelCountOfShppngRoom.Text = "Количество\r\nторговых залов:\r\n";
            // 
            // labelTypeOfShppngRoom
            // 
            this.labelTypeOfShppngRoom.AutoSize = true;
            this.labelTypeOfShppngRoom.Location = new System.Drawing.Point(12, 9);
            this.labelTypeOfShppngRoom.Name = "labelTypeOfShppngRoom";
            this.labelTypeOfShppngRoom.Size = new System.Drawing.Size(117, 38);
            this.labelTypeOfShppngRoom.TabIndex = 22;
            this.labelTypeOfShppngRoom.Text = "Тип торговой\r\nточки:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancel.Location = new System.Drawing.Point(190, 116);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdd.Location = new System.Drawing.Point(76, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 34);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxTupeOfShppngRoom
            // 
            this.comboBoxTupeOfShppngRoom.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxTupeOfShppngRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTupeOfShppngRoom.FormattingEnabled = true;
            this.comboBoxTupeOfShppngRoom.Items.AddRange(new object[] {
            "Универмаг",
            "Магазин",
            "Торговый центр",
            "Супермаркет",
            "Гипермаркет",
            "Киоск"});
            this.comboBoxTupeOfShppngRoom.Location = new System.Drawing.Point(162, 20);
            this.comboBoxTupeOfShppngRoom.Name = "comboBoxTupeOfShppngRoom";
            this.comboBoxTupeOfShppngRoom.Size = new System.Drawing.Size(142, 27);
            this.comboBoxTupeOfShppngRoom.TabIndex = 0;
            // 
            // textBoxCountOfPlace
            // 
            this.textBoxCountOfPlace.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxCountOfPlace.Location = new System.Drawing.Point(162, 76);
            this.textBoxCountOfPlace.MaxLength = 10;
            this.textBoxCountOfPlace.Name = "textBoxCountOfPlace";
            this.textBoxCountOfPlace.Size = new System.Drawing.Size(142, 26);
            this.textBoxCountOfPlace.TabIndex = 2;
            this.textBoxCountOfPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountOfPlace_KeyPress);
            // 
            // AddOutletForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(310, 162);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxCountOfPlace);
            this.Controls.Add(this.comboBoxTupeOfShppngRoom);
            this.Controls.Add(this.labelCountOfShppngRoom);
            this.Controls.Add(this.labelTypeOfShppngRoom);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddOutletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление торговой точки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCountOfShppngRoom;
        private System.Windows.Forms.Label labelTypeOfShppngRoom;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTupeOfShppngRoom;
        private System.Windows.Forms.TextBox textBoxCountOfPlace;
    }
}