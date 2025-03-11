namespace Aula59
{
    partial class Aula59
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_veiculo = new System.Windows.Forms.TextBox();
            this.txt_mult_veiculo = new System.Windows.Forms.TextBox();
            this.lb_veiculo = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.list_veiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(192, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 27);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Location = new System.Drawing.Point(21, 28);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.Size = new System.Drawing.Size(165, 22);
            this.txt_veiculo.TabIndex = 1;
            // 
            // txt_mult_veiculo
            // 
            this.txt_mult_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mult_veiculo.Location = new System.Drawing.Point(21, 56);
            this.txt_mult_veiculo.Multiline = true;
            this.txt_mult_veiculo.Name = "txt_mult_veiculo";
            this.txt_mult_veiculo.Size = new System.Drawing.Size(248, 306);
            this.txt_mult_veiculo.TabIndex = 2;
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(18, 9);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(111, 16);
            this.lb_veiculo.TabIndex = 3;
            this.lb_veiculo.Text = "Digite um Veiculo";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(21, 368);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(165, 24);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // list_veiculo
            // 
            this.list_veiculo.Location = new System.Drawing.Point(192, 368);
            this.list_veiculo.Name = "list_veiculo";
            this.list_veiculo.Size = new System.Drawing.Size(77, 26);
            this.list_veiculo.TabIndex = 5;
            this.list_veiculo.Text = "Lista";
            this.list_veiculo.UseVisualStyleBackColor = true;
            this.list_veiculo.Click += new System.EventHandler(this.list_veiculo_Click);
            // 
            // Aula59
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 408);
            this.Controls.Add(this.list_veiculo);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_veiculo);
            this.Controls.Add(this.txt_mult_veiculo);
            this.Controls.Add(this.txt_veiculo);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Aula59";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula 59";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_veiculo;
        private System.Windows.Forms.TextBox txt_mult_veiculo;
        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button list_veiculo;
    }
}

