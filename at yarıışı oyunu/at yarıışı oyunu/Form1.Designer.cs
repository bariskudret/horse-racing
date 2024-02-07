namespace at_yarıışı_oyunu
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
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.atBir = new System.Windows.Forms.PictureBox();
            this.atİki = new System.Windows.Forms.PictureBox();
            this.atuc = new System.Windows.Forms.PictureBox();
            this.bitis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.atBir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atİki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atuc)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(12, 421);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(93, 80);
            this.start.TabIndex = 0;
            this.start.Text = "BAŞLA";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1084, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(0, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1084, 16);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1084, 16);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // atBir
            // 
            this.atBir.Image = global::at_yarıışı_oyunu.Properties.Resources.at_gif;
            this.atBir.Location = new System.Drawing.Point(3, 12);
            this.atBir.Name = "atBir";
            this.atBir.Size = new System.Drawing.Size(78, 50);
            this.atBir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atBir.TabIndex = 6;
            this.atBir.TabStop = false;
            this.atBir.Click += new System.EventHandler(this.Form1_Load);
            // 
            // atİki
            // 
            this.atİki.Image = global::at_yarıışı_oyunu.Properties.Resources.kosucu;
            this.atİki.Location = new System.Drawing.Point(3, 127);
            this.atİki.Name = "atİki";
            this.atİki.Size = new System.Drawing.Size(78, 50);
            this.atİki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atİki.TabIndex = 5;
            this.atİki.TabStop = false;
            this.atİki.Click += new System.EventHandler(this.Form1_Load);
            // 
            // atuc
            // 
            this.atuc.Image = global::at_yarıışı_oyunu.Properties.Resources.koşucu1;
            this.atuc.Location = new System.Drawing.Point(3, 234);
            this.atuc.Name = "atuc";
            this.atuc.Size = new System.Drawing.Size(78, 50);
            this.atuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atuc.TabIndex = 4;
            this.atuc.TabStop = false;
            // 
            // bitis
            // 
            this.bitis.BackColor = System.Drawing.Color.DodgerBlue;
            this.bitis.Location = new System.Drawing.Point(1090, 1);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(36, 361);
            this.bitis.TabIndex = 7;
            this.bitis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bitis.Click += new System.EventHandler(this.Form1_Load);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1138, 523);
            this.Controls.Add(this.bitis);
            this.Controls.Add(this.atBir);
            this.Controls.Add(this.atİki);
            this.Controls.Add(this.atuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atBir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atİki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox atuc;
        private System.Windows.Forms.PictureBox atİki;
        private System.Windows.Forms.PictureBox atBir;
        private System.Windows.Forms.Label bitis;
        private System.Windows.Forms.Timer timer1;
    }
}

