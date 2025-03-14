namespace Aula59
{
    partial class F_LinkLabel
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_tbName = new System.Windows.Forms.Label();
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_mult = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(32, 50);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(184, 22);
            this.tb_name.TabIndex = 0;
            // 
            // lb_tbName
            // 
            this.lb_tbName.AutoSize = true;
            this.lb_tbName.Location = new System.Drawing.Point(29, 31);
            this.lb_tbName.Name = "lb_tbName";
            this.lb_tbName.Size = new System.Drawing.Size(174, 20);
            this.lb_tbName.TabIndex = 1;
            this.lb_tbName.Text = "Digite Seu Nome Aqui";
            this.lb_tbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(29, 86);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(42, 16);
            this.ll_canal.TabIndex = 2;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Canal";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(123, 86);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(80, 16);
            this.ll_calculadora.TabIndex = 3;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_mult
            // 
            this.ll_mult.AutoSize = true;
            this.ll_mult.Location = new System.Drawing.Point(29, 128);
            this.ll_mult.Name = "ll_mult";
            this.ll_mult.Size = new System.Drawing.Size(244, 20);
            this.ll_mult.TabIndex = 4;
            this.ll_mult.TabStop = true;
            this.ll_mult.Text = "Google - Calculadora - Youtube";
            this.ll_mult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_mult_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ll_mult);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_canal);
            this.Controls.Add(this.lb_tbName);
            this.Controls.Add(this.tb_name);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_tbName;
        private System.Windows.Forms.LinkLabel ll_canal;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_mult;
    }
}