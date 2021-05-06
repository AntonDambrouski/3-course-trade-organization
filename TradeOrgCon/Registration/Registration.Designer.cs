namespace TradeOrgCon.Registration
{
    partial class Registration
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.labelPassw = new System.Windows.Forms.Label();
            this.textBoxRepeatPassw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.checkBoxShowPassw = new System.Windows.Forms.CheckBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxName.Location = new System.Drawing.Point(101, 22);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 26);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxSurname.Location = new System.Drawing.Point(101, 59);
            this.textBoxSurname.MaxLength = 30;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(147, 26);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 62);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(81, 19);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxLogin.Location = new System.Drawing.Point(101, 131);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(147, 26);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 134);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 19);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxPassw.Location = new System.Drawing.Point(101, 163);
            this.textBoxPassw.MaxLength = 50;
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.PasswordChar = '*';
            this.textBoxPassw.Size = new System.Drawing.Size(147, 26);
            this.textBoxPassw.TabIndex = 4;
            this.textBoxPassw.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassw_KeyPress);
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.Location = new System.Drawing.Point(12, 166);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(72, 19);
            this.labelPassw.TabIndex = 6;
            this.labelPassw.Text = "Пароль:";
            // 
            // textBoxRepeatPassw
            // 
            this.textBoxRepeatPassw.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxRepeatPassw.Location = new System.Drawing.Point(101, 215);
            this.textBoxRepeatPassw.MaxLength = 50;
            this.textBoxRepeatPassw.Name = "textBoxRepeatPassw";
            this.textBoxRepeatPassw.PasswordChar = '*';
            this.textBoxRepeatPassw.Size = new System.Drawing.Size(147, 26);
            this.textBoxRepeatPassw.TabIndex = 6;
            this.textBoxRepeatPassw.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxRepeatPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassw_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Повторите\r\nпароль:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxPosition.Location = new System.Drawing.Point(101, 96);
            this.textBoxPosition.MaxLength = 50;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(147, 26);
            this.textBoxPosition.TabIndex = 2;
            this.textBoxPosition.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(12, 100);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(88, 18);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Должность:";
            // 
            // checkBoxShowPassw
            // 
            this.checkBoxShowPassw.AutoSize = true;
            this.checkBoxShowPassw.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxShowPassw.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassw.Location = new System.Drawing.Point(132, 192);
            this.checkBoxShowPassw.Name = "checkBoxShowPassw";
            this.checkBoxShowPassw.Size = new System.Drawing.Size(116, 17);
            this.checkBoxShowPassw.TabIndex = 5;
            this.checkBoxShowPassw.Text = "Показать пароль";
            this.checkBoxShowPassw.UseVisualStyleBackColor = false;
            this.checkBoxShowPassw.CheckedChanged += new System.EventHandler(this.checkBoxShowPassw_CheckedChanged);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRegistration.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(48, 272);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(97, 25);
            this.buttonRegistration.TabIndex = 7;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(151, 272);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 25);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Отмена";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 245);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorLabel.TabIndex = 15;
            // 
            // Registration
            // 
            this.AcceptButton = this.buttonRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(260, 309);
            this.ControlBox = false;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.checkBoxShowPassw);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxRepeatPassw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassw);
            this.Controls.Add(this.labelPassw);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.TextBox textBoxRepeatPassw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.CheckBox checkBoxShowPassw;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label ErrorLabel;
    }
}