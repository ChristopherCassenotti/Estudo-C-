namespace Aula59
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.l_carro = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.ItemHeight = 16;
            this.lb_carros.Location = new System.Drawing.Point(12, 12);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(188, 372);
            this.lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(206, 33);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(100, 22);
            this.tb_carro.TabIndex = 1;
            // 
            // l_carro
            // 
            this.l_carro.AutoSize = true;
            this.l_carro.Location = new System.Drawing.Point(206, 14);
            this.l_carro.Name = "l_carro";
            this.l_carro.Size = new System.Drawing.Size(50, 20);
            this.l_carro.TabIndex = 2;
            this.l_carro.Text = "Carro";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(206, 61);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(209, 90);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(97, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(206, 119);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(100, 23);
            this.btn_get.TabIndex = 5;
            this.btn_get.Text = "Obter";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 396);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.l_carro);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carros);
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label l_carro;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_get;
    }
}