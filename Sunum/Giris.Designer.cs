namespace Sunum
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPersonel = new System.Windows.Forms.PictureBox();
            this.pictureBoxUrun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(318, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün İşlemleri";
            // 
            // pictureBoxPersonel
            // 
            this.pictureBoxPersonel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPersonel.Image")));
            this.pictureBoxPersonel.Location = new System.Drawing.Point(18, 70);
            this.pictureBoxPersonel.Name = "pictureBoxPersonel";
            this.pictureBoxPersonel.Size = new System.Drawing.Size(262, 207);
            this.pictureBoxPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersonel.TabIndex = 2;
            this.pictureBoxPersonel.TabStop = false;
            this.pictureBoxPersonel.Click += new System.EventHandler(this.pictureBoxPersonel_Click);
            // 
            // pictureBoxUrun
            // 
            this.pictureBoxUrun.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUrun.Image")));
            this.pictureBoxUrun.Location = new System.Drawing.Point(312, 70);
            this.pictureBoxUrun.Name = "pictureBoxUrun";
            this.pictureBoxUrun.Size = new System.Drawing.Size(239, 207);
            this.pictureBoxUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUrun.TabIndex = 3;
            this.pictureBoxUrun.TabStop = false;
            this.pictureBoxUrun.Click += new System.EventHandler(this.pictureBoxUrun_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(563, 292);
            this.Controls.Add(this.pictureBoxUrun);
            this.Controls.Add(this.pictureBoxPersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Giris";
            this.Text = "Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPersonel;
        private System.Windows.Forms.PictureBox pictureBoxUrun;
    }
}

