namespace Aula59
{
    partial class F_PictureBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_imgs = new System.Windows.Forms.PictureBox();
            this.btn_img1 = new System.Windows.Forms.Button();
            this.btn_img2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pb_imgs
            // 
            this.pb_imgs.Image = global::Aula59.Properties.Resources.snoopy;
            this.pb_imgs.Location = new System.Drawing.Point(19, 18);
            this.pb_imgs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_imgs.Name = "pb_imgs";
            this.pb_imgs.Size = new System.Drawing.Size(430, 321);
            this.pb_imgs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imgs.TabIndex = 2;
            this.pb_imgs.TabStop = false;
            // 
            // btn_img1
            // 
            this.btn_img1.Location = new System.Drawing.Point(467, 71);
            this.btn_img1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_img1.Name = "btn_img1";
            this.btn_img1.Size = new System.Drawing.Size(56, 29);
            this.btn_img1.TabIndex = 3;
            this.btn_img1.Text = "Img1";
            this.btn_img1.UseVisualStyleBackColor = true;
            this.btn_img1.Click += new System.EventHandler(this.btn_img1_Click);
            // 
            // btn_img2
            // 
            this.btn_img2.Location = new System.Drawing.Point(468, 104);
            this.btn_img2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_img2.Name = "btn_img2";
            this.btn_img2.Size = new System.Drawing.Size(56, 28);
            this.btn_img2.TabIndex = 4;
            this.btn_img2.Text = "Img2";
            this.btn_img2.UseVisualStyleBackColor = true;
            this.btn_img2.Click += new System.EventHandler(this.btn_img2_Click);
            // 
            // F_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_img2);
            this.Controls.Add(this.btn_img1);
            this.Controls.Add(this.pb_imgs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_PictureBox";
            this.Text = "F_PictureBox";
            this.Load += new System.EventHandler(this.F_PictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_imgs;
        private System.Windows.Forms.Button btn_img1;
        private System.Windows.Forms.Button btn_img2;
    }
}