namespace TradeOrgCon.Authorization
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPassw = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.linkLabelRegistr = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgotPassw = new System.Windows.Forms.LinkLabel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelErrorPassw = new System.Windows.Forms.Label();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.labelShowPassw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(13, 13);
            this.labelLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(63, 19);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Логин:";
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.Location = new System.Drawing.Point(13, 58);
            this.labelPassw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(72, 19);
            this.labelPassw.TabIndex = 1;
            this.labelPassw.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxPassword.Location = new System.Drawing.Point(92, 55);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 26);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxLogin.Location = new System.Drawing.Point(92, 10);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(214, 26);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // linkLabelRegistr
            // 
            this.linkLabelRegistr.AutoSize = true;
            this.linkLabelRegistr.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelRegistr.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelRegistr.Location = new System.Drawing.Point(14, 114);
            this.linkLabelRegistr.Name = "linkLabelRegistr";
            this.linkLabelRegistr.Size = new System.Drawing.Size(84, 14);
            this.linkLabelRegistr.TabIndex = 5;
            this.linkLabelRegistr.TabStop = true;
            this.linkLabelRegistr.Text = "Регистрация";
            this.linkLabelRegistr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistr_LinkClicked);
            this.linkLabelRegistr.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // linkLabelForgotPassw
            // 
            this.linkLabelForgotPassw.AutoSize = true;
            this.linkLabelForgotPassw.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelForgotPassw.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelForgotPassw.Location = new System.Drawing.Point(14, 95);
            this.linkLabelForgotPassw.Name = "linkLabelForgotPassw";
            this.linkLabelForgotPassw.Size = new System.Drawing.Size(105, 14);
            this.linkLabelForgotPassw.TabIndex = 4;
            this.linkLabelForgotPassw.TabStop = true;
            this.linkLabelForgotPassw.Text = "Забыли пароль?";
            this.linkLabelForgotPassw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPassw_LinkClicked);
            this.linkLabelForgotPassw.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonEnter.Location = new System.Drawing.Point(150, 124);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 25);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            this.buttonEnter.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonExit.Location = new System.Drawing.Point(231, 124);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelErrorPassw
            // 
            this.labelErrorPassw.AutoSize = true;
            this.labelErrorPassw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelErrorPassw.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorPassw.ForeColor = System.Drawing.Color.DarkRed;
            this.labelErrorPassw.Location = new System.Drawing.Point(120, 84);
            this.labelErrorPassw.Name = "labelErrorPassw";
            this.labelErrorPassw.Size = new System.Drawing.Size(0, 14);
            this.labelErrorPassw.TabIndex = 6;
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelErrorLogin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.labelErrorLogin.Location = new System.Drawing.Point(120, 39);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(0, 14);
            this.labelErrorLogin.TabIndex = 7;
            // 
            // labelShowPassw
            // 
            this.labelShowPassw.AutoSize = true;
            this.labelShowPassw.BackColor = System.Drawing.Color.AliceBlue;
            this.labelShowPassw.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowPassw.Location = new System.Drawing.Point(239, 61);
            this.labelShowPassw.Name = "labelShowPassw";
            this.labelShowPassw.Size = new System.Drawing.Size(63, 15);
            this.labelShowPassw.TabIndex = 8;
            this.labelShowPassw.Text = "Показать";
            this.labelShowPassw.Click += new System.EventHandler(this.labelShowPassw_Click);
            // 
            // Authorization
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(318, 161);
            this.ControlBox = false;
            this.Controls.Add(this.labelShowPassw);
            this.Controls.Add(this.labelErrorLogin);
            this.Controls.Add(this.labelErrorPassw);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.linkLabelForgotPassw);
            this.Controls.Add(this.linkLabelRegistr);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassw);
            this.Controls.Add(this.labelLog);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabelRegistr;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassw;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelErrorPassw;
        private System.Windows.Forms.Label labelErrorLogin;
        private System.Windows.Forms.Label labelShowPassw;
    }
}

