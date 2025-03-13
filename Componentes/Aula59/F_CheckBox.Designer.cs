namespace Aula59
{
    partial class F_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_moto = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_cbCheck = new System.Windows.Forms.Button();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.btn_openFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(19, 26);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(62, 20);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(19, 52);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(65, 20);
            this.cb_navio.TabIndex = 1;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_moto
            // 
            this.cb_moto.AutoSize = true;
            this.cb_moto.Location = new System.Drawing.Point(19, 78);
            this.cb_moto.Name = "cb_moto";
            this.cb_moto.Size = new System.Drawing.Size(59, 20);
            this.cb_moto.TabIndex = 2;
            this.cb_moto.Text = "Moto";
            this.cb_moto.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(19, 104);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(71, 20);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_cbCheck
            // 
            this.btn_cbCheck.Location = new System.Drawing.Point(117, 26);
            this.btn_cbCheck.Name = "btn_cbCheck";
            this.btn_cbCheck.Size = new System.Drawing.Size(165, 34);
            this.btn_cbCheck.TabIndex = 4;
            this.btn_cbCheck.Text = "Transportes Marcados";
            this.btn_cbCheck.UseVisualStyleBackColor = true;
            this.btn_cbCheck.Click += new System.EventHandler(this.btn_cbCheck_Click);
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(19, 147);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(78, 20);
            this.cb_patinete.TabIndex = 5;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // btn_openFilho
            // 
            this.btn_openFilho.Location = new System.Drawing.Point(117, 66);
            this.btn_openFilho.Name = "btn_openFilho";
            this.btn_openFilho.Size = new System.Drawing.Size(165, 32);
            this.btn_openFilho.TabIndex = 6;
            this.btn_openFilho.Text = "Abrir Filho";
            this.btn_openFilho.UseVisualStyleBackColor = true;
            this.btn_openFilho.Click += new System.EventHandler(this.btn_openFilho_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 184);
            this.Controls.Add(this.btn_openFilho);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.btn_cbCheck);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_moto);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cbCheck;
        private System.Windows.Forms.CheckBox cb_patinete;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_navio;
        public System.Windows.Forms.CheckBox cb_moto;
        public System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button btn_openFilho;
    }
}