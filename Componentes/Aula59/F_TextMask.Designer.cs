namespace Aula59
{
    partial class F_TextMask
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
            this.mtb_password = new System.Windows.Forms.MaskedTextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_cpf = new System.Windows.Forms.Button();
            this.cb_texto = new System.Windows.Forms.CheckBox();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_password
            // 
            this.mtb_password.Location = new System.Drawing.Point(12, 31);
            this.mtb_password.Name = "mtb_password";
            this.mtb_password.PasswordChar = '*';
            this.mtb_password.Size = new System.Drawing.Size(199, 20);
            this.mtb_password.TabIndex = 0;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(13, 13);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(12, 106);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(199, 20);
            this.mtb_cpf.TabIndex = 2;
            this.mtb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_cpf
            // 
            this.btn_cpf.Location = new System.Drawing.Point(218, 102);
            this.btn_cpf.Name = "btn_cpf";
            this.btn_cpf.Size = new System.Drawing.Size(75, 23);
            this.btn_cpf.TabIndex = 3;
            this.btn_cpf.Text = "button1";
            this.btn_cpf.UseVisualStyleBackColor = true;
            this.btn_cpf.Click += new System.EventHandler(this.btn_cpf_Click);
            // 
            // cb_texto
            // 
            this.cb_texto.AutoSize = true;
            this.cb_texto.Location = new System.Drawing.Point(300, 106);
            this.cb_texto.Name = "cb_texto";
            this.cb_texto.Size = new System.Drawing.Size(98, 17);
            this.cb_texto.TabIndex = 4;
            this.cb_texto.Text = "Somente Texto";
            this.cb_texto.UseVisualStyleBackColor = true;
            this.cb_texto.CheckedChanged += new System.EventHandler(this.cb_texto_CheckedChanged);
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Location = new System.Drawing.Point(12, 57);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(102, 17);
            this.cb_showPassword.TabIndex = 5;
            this.cb_showPassword.Text = "Show Password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // F_TextMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 156);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.cb_texto);
            this.Controls.Add(this.btn_cpf);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.mtb_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_TextMask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_TextMask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Button btn_cpf;
        private System.Windows.Forms.CheckBox cb_texto;
        private System.Windows.Forms.CheckBox cb_showPassword;
    }
}