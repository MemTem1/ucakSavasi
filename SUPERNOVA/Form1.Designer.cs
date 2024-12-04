namespace SUPERNOVA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelOyunSahasi = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerDusman = new System.Windows.Forms.Timer(this.components);
            this.timerBullet = new System.Windows.Forms.Timer(this.components);
            this.labelAd = new System.Windows.Forms.Label();
            this.panelOyunSahasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOyunSahasi
            // 
            this.panelOyunSahasi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelOyunSahasi.Controls.Add(this.pictureBox1);
            this.panelOyunSahasi.Location = new System.Drawing.Point(0, 83);
            this.panelOyunSahasi.Name = "panelOyunSahasi";
            this.panelOyunSahasi.Size = new System.Drawing.Size(982, 536);
            this.panelOyunSahasi.TabIndex = 0;
            this.panelOyunSahasi.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SUPERNOVA.Properties.Resources.bizim_uçak_png;
            this.pictureBox1.Location = new System.Drawing.Point(422, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.labelAd);
            this.panel2.Controls.Add(this.labelCan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelPuan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 78);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelCan
            // 
            this.labelCan.AutoSize = true;
            this.labelCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCan.Location = new System.Drawing.Point(290, 31);
            this.labelCan.Name = "labelCan";
            this.labelCan.Size = new System.Drawing.Size(19, 20);
            this.labelCan.TabIndex = 4;
            this.labelCan.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(213, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Can :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPuan.Location = new System.Drawing.Point(129, 31);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(19, 20);
            this.labelPuan.TabIndex = 1;
            this.labelPuan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puan :";
            // 
            // timerDusman
            // 
            this.timerDusman.Interval = 20;
            this.timerDusman.Tick += new System.EventHandler(this.timerDusman_Tick);
            // 
            // timerBullet
            // 
            this.timerBullet.Interval = 10;
            this.timerBullet.Tick += new System.EventHandler(this.timerBullet_Tick);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(688, 31);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(57, 25);
            this.labelAd.TabIndex = 6;
            this.labelAd.Text = "İSİM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(982, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOyunSahasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPERNOVA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelOyunSahasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOyunSahasi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDusman;
        private System.Windows.Forms.Timer timerBullet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Label labelCan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAd;
    }
}

