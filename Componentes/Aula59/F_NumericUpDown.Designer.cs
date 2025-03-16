namespace Aula59
{
    partial class F_NumericUpDown
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
            this.nud_value = new System.Windows.Forms.NumericUpDown();
            this.tb_setValue = new System.Windows.Forms.TextBox();
            this.btn_setValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_value)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_value
            // 
            this.nud_value.Location = new System.Drawing.Point(12, 12);
            this.nud_value.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_value.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_value.Name = "nud_value";
            this.nud_value.Size = new System.Drawing.Size(66, 22);
            this.nud_value.TabIndex = 0;
            this.nud_value.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tb_setValue
            // 
            this.tb_setValue.Location = new System.Drawing.Point(99, 11);
            this.tb_setValue.Name = "tb_setValue";
            this.tb_setValue.Size = new System.Drawing.Size(100, 22);
            this.tb_setValue.TabIndex = 1;
            this.tb_setValue.Text = "1";
            // 
            // btn_setValue
            // 
            this.btn_setValue.Location = new System.Drawing.Point(205, 12);
            this.btn_setValue.Name = "btn_setValue";
            this.btn_setValue.Size = new System.Drawing.Size(75, 23);
            this.btn_setValue.TabIndex = 2;
            this.btn_setValue.Text = "Set Value";
            this.btn_setValue.UseVisualStyleBackColor = true;
            this.btn_setValue.Click += new System.EventHandler(this.btn_setValue_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 74);
            this.Controls.Add(this.btn_setValue);
            this.Controls.Add(this.tb_setValue);
            this.Controls.Add(this.nud_value);
            this.Name = "F_NumericUpDown";
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nud_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_value;
        private System.Windows.Forms.TextBox tb_setValue;
        private System.Windows.Forms.Button btn_setValue;
    }
}