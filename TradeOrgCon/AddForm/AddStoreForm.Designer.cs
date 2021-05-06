namespace TradeOrgCon.AddForm
{
    partial class AddStoreForm
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
            this.labelCountOfShppngRoom = new System.Windows.Forms.Label();
            this.labelTypeOfShppngRoom = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNameOfProduct = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCountOfShppngRoom
            // 
            this.labelCountOfShppngRoom.AutoSize = true;
            this.labelCountOfShppngRoom.Location = new System.Drawing.Point(12, 68);
            this.labelCountOfShppngRoom.Name = "labelCountOfShppngRoom";
            this.labelCountOfShppngRoom.Size = new System.Drawing.Size(108, 19);
            this.labelCountOfShppngRoom.TabIndex = 28;
            this.labelCountOfShppngRoom.Text = "Количество:\r\n";
            // 
            // labelTypeOfShppngRoom
            // 
            this.labelTypeOfShppngRoom.AutoSize = true;
            this.labelTypeOfShppngRoom.Location = new System.Drawing.Point(12, 9);
            this.labelTypeOfShppngRoom.Name = "labelTypeOfShppngRoom";
            this.labelTypeOfShppngRoom.Size = new System.Drawing.Size(117, 38);
            this.labelTypeOfShppngRoom.TabIndex = 27;
            this.labelTypeOfShppngRoom.Text = "Наименование\r\nтовара:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancel.Location = new System.Drawing.Point(175, 131);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 34);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdd.Location = new System.Drawing.Point(61, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNameOfProduct
            // 
            this.textBoxNameOfProduct.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxNameOfProduct.Location = new System.Drawing.Point(136, 21);
            this.textBoxNameOfProduct.Name = "textBoxNameOfProduct";
            this.textBoxNameOfProduct.Size = new System.Drawing.Size(142, 26);
            this.textBoxNameOfProduct.TabIndex = 0;
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxCount.Location = new System.Drawing.Point(136, 65);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(142, 26);
            this.textBoxCount.TabIndex = 1;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // AddStoreForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(295, 177);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxNameOfProduct);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCountOfShppngRoom);
            this.Controls.Add(this.labelTypeOfShppngRoom);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddStoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCountOfShppngRoom;
        private System.Windows.Forms.Label labelTypeOfShppngRoom;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNameOfProduct;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}