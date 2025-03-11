namespace Aula58
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_text = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(254, 58);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(72, 25);
            this.btn_text.TabIndex = 0;
            this.btn_text.Text = "button1";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(87, 42);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(45, 16);
            this.lb_text.TabIndex = 1;
            this.lb_text.Text = "BTN 1";
            this.lb_text.Click += new System.EventHandler(this.lb_text_Click);
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(90, 61);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(158, 22);
            this.tb_text.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.btn_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox tb_text;
    }
}

