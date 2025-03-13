namespace Aula59
{
    partial class F_CheckListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_showSelect = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_inputItem = new System.Windows.Forms.Button();
            this.tb_newTransp = new System.Windows.Forms.TextBox();
            this.lb_digTransp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(11, 26);
            this.clb_transportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(138, 184);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_showSelect
            // 
            this.btn_showSelect.Location = new System.Drawing.Point(153, 26);
            this.btn_showSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showSelect.Name = "btn_showSelect";
            this.btn_showSelect.Size = new System.Drawing.Size(174, 19);
            this.btn_showSelect.TabIndex = 1;
            this.btn_showSelect.Text = "Mostrar Selecionados";
            this.btn_showSelect.UseVisualStyleBackColor = true;
            this.btn_showSelect.Click += new System.EventHandler(this.btn_showSelect_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(154, 50);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(173, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar Lista";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(154, 79);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(173, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Resetar Lista";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_inputItem
            // 
            this.btn_inputItem.Location = new System.Drawing.Point(153, 190);
            this.btn_inputItem.Name = "btn_inputItem";
            this.btn_inputItem.Size = new System.Drawing.Size(173, 23);
            this.btn_inputItem.TabIndex = 4;
            this.btn_inputItem.Text = "Novo item";
            this.btn_inputItem.UseVisualStyleBackColor = true;
            this.btn_inputItem.Click += new System.EventHandler(this.btn_inputItem_Click);
            // 
            // tb_newTransp
            // 
            this.tb_newTransp.Location = new System.Drawing.Point(153, 164);
            this.tb_newTransp.Name = "tb_newTransp";
            this.tb_newTransp.Size = new System.Drawing.Size(174, 20);
            this.tb_newTransp.TabIndex = 5;
            // 
            // lb_digTransp
            // 
            this.lb_digTransp.AutoSize = true;
            this.lb_digTransp.Location = new System.Drawing.Point(154, 148);
            this.lb_digTransp.Name = "lb_digTransp";
            this.lb_digTransp.Size = new System.Drawing.Size(114, 13);
            this.lb_digTransp.TabIndex = 6;
            this.lb_digTransp.Text = "Digite novo trasnporte:";
            // 
            // F_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 237);
            this.Controls.Add(this.lb_digTransp);
            this.Controls.Add(this.tb_newTransp);
            this.Controls.Add(this.btn_inputItem);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_showSelect);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "F_CheckListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_showSelect;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_inputItem;
        private System.Windows.Forms.TextBox tb_newTransp;
        private System.Windows.Forms.Label lb_digTransp;
    }
}