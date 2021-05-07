
namespace TradeOrgCon.Additional_buttons
{
    partial class InputEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputEmailForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCnsl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(12, 98);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(106, 32);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Отправить";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCnsl
            // 
            this.buttonCnsl.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCnsl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCnsl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCnsl.Location = new System.Drawing.Point(154, 98);
            this.buttonCnsl.Name = "buttonCnsl";
            this.buttonCnsl.Size = new System.Drawing.Size(106, 32);
            this.buttonCnsl.TabIndex = 1;
            this.buttonCnsl.Text = "Отмена";
            this.buttonCnsl.UseVisualStyleBackColor = false;
            this.buttonCnsl.Click += new System.EventHandler(this.buttonCnsl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email получателя:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 40);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(248, 26);
            this.textBoxEmail.TabIndex = 3;
            // 
            // InputEmailForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.CancelButton = this.buttonCnsl;
            this.ClientSize = new System.Drawing.Size(272, 142);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCnsl);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InputEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отправка по email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCnsl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxEmail;
    }
}