namespace Aula59
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500.00"}, -1);
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_qntd = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.lb_qntd = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.HideSelection = false;
            listViewItem2.IndentCount = 1;
            listViewItem3.IndentCount = 2;
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(14, 33);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(611, 269);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 40;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 200;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.Width = 100;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 120;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(19, 369);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(102, 22);
            this.tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(131, 369);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(206, 22);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_qntd
            // 
            this.tb_qntd.Location = new System.Drawing.Point(343, 369);
            this.tb_qntd.Name = "tb_qntd";
            this.tb_qntd.Size = new System.Drawing.Size(127, 22);
            this.tb_qntd.TabIndex = 3;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(476, 369);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(143, 22);
            this.tb_preco.TabIndex = 4;
            this.tb_preco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(16, 350);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(20, 16);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "ID";
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(128, 350);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(54, 16);
            this.lb_produto.TabIndex = 6;
            this.lb_produto.Text = "Produto";
            // 
            // lb_qntd
            // 
            this.lb_qntd.AutoSize = true;
            this.lb_qntd.Location = new System.Drawing.Point(340, 350);
            this.lb_qntd.Name = "lb_qntd";
            this.lb_qntd.Size = new System.Drawing.Size(77, 16);
            this.lb_qntd.TabIndex = 7;
            this.lb_qntd.Text = "Quantidade";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(476, 350);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(43, 16);
            this.lb_preco.TabIndex = 8;
            this.lb_preco.Text = "Preço";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(19, 397);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 40);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(19, 443);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(118, 40);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(19, 489);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(118, 40);
            this.btn_get.TabIndex = 11;
            this.btn_get.Text = "Obter";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 575);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_qntd);
            this.Controls.Add(this.lb_produto);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_qntd);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_qntd;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label lb_qntd;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_get;
    }
}