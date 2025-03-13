namespace Aula59
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.btn_getDay = new System.Windows.Forms.Button();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_setDay = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(11, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(250, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 38);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(250, 20);
            this.tb_data.TabIndex = 1;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 64);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(78, 20);
            this.tb_dia.TabIndex = 2;
            this.tb_dia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(96, 64);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(85, 20);
            this.tb_mes.TabIndex = 3;
            // 
            // btn_getDay
            // 
            this.btn_getDay.Location = new System.Drawing.Point(268, 9);
            this.btn_getDay.Name = "btn_getDay";
            this.btn_getDay.Size = new System.Drawing.Size(138, 23);
            this.btn_getDay.TabIndex = 4;
            this.btn_getDay.Text = "Obter Data";
            this.btn_getDay.UseVisualStyleBackColor = true;
            this.btn_getDay.Click += new System.EventHandler(this.btn_getDay_Click);
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(187, 64);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(75, 20);
            this.tb_ano.TabIndex = 5;
            // 
            // btn_setDay
            // 
            this.btn_setDay.Location = new System.Drawing.Point(268, 62);
            this.btn_setDay.Name = "btn_setDay";
            this.btn_setDay.Size = new System.Drawing.Size(138, 23);
            this.btn_setDay.TabIndex = 9;
            this.btn_setDay.Text = "Setar Data";
            this.btn_setDay.UseVisualStyleBackColor = true;
            this.btn_setDay.Click += new System.EventHandler(this.btn_setDay_Click);
            // 
            // btn_today
            // 
            this.btn_today.Location = new System.Drawing.Point(268, 91);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(138, 23);
            this.btn_today.TabIndex = 10;
            this.btn_today.Text = "Data de Hoje";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 135);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.btn_setDay);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.btn_getDay);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.Button btn_getDay;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button btn_setDay;
        private System.Windows.Forms.Button btn_today;
    }
}