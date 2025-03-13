namespace Aula59
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_showSelect = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tb_trasporte = new System.Windows.Forms.TextBox();
            this.btn_add_new_trasp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Avião",
            "Skate",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(167, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_showSelect
            // 
            this.btn_showSelect.Location = new System.Drawing.Point(185, 12);
            this.btn_showSelect.Name = "btn_showSelect";
            this.btn_showSelect.Size = new System.Drawing.Size(164, 23);
            this.btn_showSelect.TabIndex = 1;
            this.btn_showSelect.Text = "Mostrar Selecionado";
            this.btn_showSelect.UseVisualStyleBackColor = true;
            this.btn_showSelect.Click += new System.EventHandler(this.btn_showSelect_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(185, 41);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(164, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(185, 70);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(164, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Resetar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tb_trasporte
            // 
            this.tb_trasporte.Location = new System.Drawing.Point(185, 131);
            this.tb_trasporte.Name = "tb_trasporte";
            this.tb_trasporte.Size = new System.Drawing.Size(164, 20);
            this.tb_trasporte.TabIndex = 4;
            // 
            // btn_add_new_trasp
            // 
            this.btn_add_new_trasp.Location = new System.Drawing.Point(185, 157);
            this.btn_add_new_trasp.Name = "btn_add_new_trasp";
            this.btn_add_new_trasp.Size = new System.Drawing.Size(164, 23);
            this.btn_add_new_trasp.TabIndex = 5;
            this.btn_add_new_trasp.Text = "Add";
            this.btn_add_new_trasp.UseVisualStyleBackColor = true;
            this.btn_add_new_trasp.Click += new System.EventHandler(this.btn_add_new_trasp_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 217);
            this.Controls.Add(this.btn_add_new_trasp);
            this.Controls.Add(this.tb_trasporte);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_showSelect);
            this.Controls.Add(this.cb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_showSelect;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tb_trasporte;
        private System.Windows.Forms.Button btn_add_new_trasp;
    }
}