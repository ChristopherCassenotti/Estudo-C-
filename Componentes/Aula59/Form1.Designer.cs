namespace Aula59
{
    partial class F_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_veiculo = new System.Windows.Forms.TextBox();
            this.txt_mult_veiculo = new System.Windows.Forms.TextBox();
            this.lb_veiculo = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.list_veiculo = new System.Windows.Forms.Button();
            this.btn_showV = new System.Windows.Forms.Button();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumericUpDown = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_msg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(187, 62);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 27);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Location = new System.Drawing.Point(15, 66);
            this.txt_veiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.Size = new System.Drawing.Size(165, 22);
            this.txt_veiculo.TabIndex = 1;
            // 
            // txt_mult_veiculo
            // 
            this.txt_mult_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mult_veiculo.Location = new System.Drawing.Point(15, 95);
            this.txt_mult_veiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mult_veiculo.Multiline = true;
            this.txt_mult_veiculo.Name = "txt_mult_veiculo";
            this.txt_mult_veiculo.ReadOnly = true;
            this.txt_mult_veiculo.Size = new System.Drawing.Size(248, 306);
            this.txt_mult_veiculo.TabIndex = 2;
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(12, 48);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(111, 16);
            this.lb_veiculo.TabIndex = 3;
            this.lb_veiculo.Text = "Digite um Veiculo";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(15, 407);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(165, 25);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // list_veiculo
            // 
            this.list_veiculo.Location = new System.Drawing.Point(187, 407);
            this.list_veiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_veiculo.Name = "list_veiculo";
            this.list_veiculo.Size = new System.Drawing.Size(77, 26);
            this.list_veiculo.TabIndex = 5;
            this.list_veiculo.Text = "Lista";
            this.list_veiculo.UseVisualStyleBackColor = true;
            this.list_veiculo.Click += new System.EventHandler(this.list_veiculo_Click);
            // 
            // btn_showV
            // 
            this.btn_showV.Location = new System.Drawing.Point(15, 446);
            this.btn_showV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showV.Name = "btn_showV";
            this.btn_showV.Size = new System.Drawing.Size(248, 23);
            this.btn_showV.TabIndex = 6;
            this.btn_showV.Text = "Mostrar Veiculos";
            this.btn_showV.UseVisualStyleBackColor = true;
            this.btn_showV.Click += new System.EventHandler(this.btn_showV_Click);
            // 
            // btn_valNum
            // 
            this.btn_valNum.Location = new System.Drawing.Point(15, 475);
            this.btn_valNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(248, 23);
            this.btn_valNum.TabIndex = 7;
            this.btn_valNum.Text = "Valor num";
            this.btn_valNum.UseVisualStyleBackColor = true;
            this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componetesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(283, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // componetesToolStripMenuItem
            // 
            this.componetesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.NumericUpDown,
            this.pictureBoxToolStripMenuItem});
            this.componetesToolStripMenuItem.Name = "componetesToolStripMenuItem";
            this.componetesToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.componetesToolStripMenuItem.Text = "Componetes";
            this.componetesToolStripMenuItem.Click += new System.EventHandler(this.componetesToolStripMenuItem_Click);
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkBoxToolStripMenuItem.Text = "Check Box";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkListBoxToolStripMenuItem
            // 
            this.checkListBoxToolStripMenuItem.Name = "checkListBoxToolStripMenuItem";
            this.checkListBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkListBoxToolStripMenuItem.Text = "List Check Box";
            this.checkListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comboBoxToolStripMenuItem.Text = "Combo Box";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dateTimePickerToolStripMenuItem.Text = "DateTime Picker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.monthCalendarToolStripMenuItem.Text = "Month Calendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(224, 26);
            this.NumericUpDown.Text = "NumericUpDown";
            this.NumericUpDown.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Curso";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificoes
            // 
            this.MenuNotificoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuNotificoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_restaurar,
            this.tsmi_msg,
            this.tsmi_close});
            this.MenuNotificoes.Name = "MenuNotificoes";
            this.MenuNotificoes.Size = new System.Drawing.Size(152, 76);
            this.MenuNotificoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificoes_ItemClicked);
            // 
            // tsmi_restaurar
            // 
            this.tsmi_restaurar.Name = "tsmi_restaurar";
            this.tsmi_restaurar.Size = new System.Drawing.Size(151, 24);
            this.tsmi_restaurar.Text = "Restaurar";
            // 
            // tsmi_msg
            // 
            this.tsmi_msg.Name = "tsmi_msg";
            this.tsmi_msg.Size = new System.Drawing.Size(151, 24);
            this.tsmi_msg.Text = "Mensagem";
            // 
            // tsmi_close
            // 
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Size = new System.Drawing.Size(151, 24);
            this.tsmi_close.Text = "Fechar";
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 503);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.btn_showV);
            this.Controls.Add(this.list_veiculo);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_veiculo);
            this.Controls.Add(this.txt_mult_veiculo);
            this.Controls.Add(this.txt_veiculo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_veiculo;
        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button list_veiculo;
        private System.Windows.Forms.Button btn_showV;
        private System.Windows.Forms.Button btn_valNum;
        public System.Windows.Forms.TextBox txt_mult_veiculo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumericUpDown;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_msg;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
    }
}

