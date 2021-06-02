namespace YapisalHafta7
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
            this.btn_dosyakonrol = new System.Windows.Forms.Button();
            this.btn_dizinal = new System.Windows.Forms.Button();
            this.btn_dosyaolustur = new System.Windows.Forms.Button();
            this.btn_dosyayaz = new System.Windows.Forms.Button();
            this.btn_dosyauzerineyaz = new System.Windows.Forms.Button();
            this.btn_dosyasil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dosyakonrol
            // 
            this.btn_dosyakonrol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dosyakonrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyakonrol.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_dosyakonrol.Location = new System.Drawing.Point(17, 16);
            this.btn_dosyakonrol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dosyakonrol.Name = "btn_dosyakonrol";
            this.btn_dosyakonrol.Size = new System.Drawing.Size(431, 54);
            this.btn_dosyakonrol.TabIndex = 0;
            this.btn_dosyakonrol.Text = "Dosya Var mı?";
            this.btn_dosyakonrol.UseVisualStyleBackColor = false;
            this.btn_dosyakonrol.Click += new System.EventHandler(this.btn_dosyakonrol_Click);
            // 
            // btn_dizinal
            // 
            this.btn_dizinal.BackColor = System.Drawing.Color.DimGray;
            this.btn_dizinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dizinal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_dizinal.Location = new System.Drawing.Point(16, 78);
            this.btn_dizinal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dizinal.Name = "btn_dizinal";
            this.btn_dizinal.Size = new System.Drawing.Size(431, 54);
            this.btn_dizinal.TabIndex = 1;
            this.btn_dizinal.Text = "Dizin Al";
            this.btn_dizinal.UseVisualStyleBackColor = false;
            this.btn_dizinal.Click += new System.EventHandler(this.btn_dizinal_Click);
            // 
            // btn_dosyaolustur
            // 
            this.btn_dosyaolustur.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_dosyaolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyaolustur.Location = new System.Drawing.Point(16, 139);
            this.btn_dosyaolustur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dosyaolustur.Name = "btn_dosyaolustur";
            this.btn_dosyaolustur.Size = new System.Drawing.Size(431, 54);
            this.btn_dosyaolustur.TabIndex = 2;
            this.btn_dosyaolustur.Text = "Dosya Oluştur";
            this.btn_dosyaolustur.UseVisualStyleBackColor = false;
            this.btn_dosyaolustur.Click += new System.EventHandler(this.btn_dosyaolustur_Click);
            // 
            // btn_dosyayaz
            // 
            this.btn_dosyayaz.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_dosyayaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyayaz.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_dosyayaz.Location = new System.Drawing.Point(17, 201);
            this.btn_dosyayaz.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dosyayaz.Name = "btn_dosyayaz";
            this.btn_dosyayaz.Size = new System.Drawing.Size(431, 54);
            this.btn_dosyayaz.TabIndex = 3;
            this.btn_dosyayaz.Text = "Dosya Yaz Write";
            this.btn_dosyayaz.UseVisualStyleBackColor = false;
            this.btn_dosyayaz.Click += new System.EventHandler(this.btn_dosyayaz_Click);
            // 
            // btn_dosyauzerineyaz
            // 
            this.btn_dosyauzerineyaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_dosyauzerineyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyauzerineyaz.Location = new System.Drawing.Point(17, 262);
            this.btn_dosyauzerineyaz.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dosyauzerineyaz.Name = "btn_dosyauzerineyaz";
            this.btn_dosyauzerineyaz.Size = new System.Drawing.Size(431, 54);
            this.btn_dosyauzerineyaz.TabIndex = 4;
            this.btn_dosyauzerineyaz.Text = "Dosya Üzerine Yaz (Append)";
            this.btn_dosyauzerineyaz.UseVisualStyleBackColor = false;
            this.btn_dosyauzerineyaz.Click += new System.EventHandler(this.btn_dosyauzerineyaz_Click);
            // 
            // btn_dosyasil
            // 
            this.btn_dosyasil.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_dosyasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyasil.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_dosyasil.Location = new System.Drawing.Point(17, 324);
            this.btn_dosyasil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dosyasil.Name = "btn_dosyasil";
            this.btn_dosyasil.Size = new System.Drawing.Size(431, 54);
            this.btn_dosyasil.TabIndex = 5;
            this.btn_dosyasil.Text = "Dosya Sil";
            this.btn_dosyasil.UseVisualStyleBackColor = false;
            this.btn_dosyasil.Click += new System.EventHandler(this.btn_dosyasil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(19, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "RePlace";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_dosyasil);
            this.Controls.Add(this.btn_dosyauzerineyaz);
            this.Controls.Add(this.btn_dosyayaz);
            this.Controls.Add(this.btn_dosyaolustur);
            this.Controls.Add(this.btn_dizinal);
            this.Controls.Add(this.btn_dosyakonrol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dosyakonrol;
        private System.Windows.Forms.Button btn_dizinal;
        private System.Windows.Forms.Button btn_dosyaolustur;
        private System.Windows.Forms.Button btn_dosyayaz;
        private System.Windows.Forms.Button btn_dosyauzerineyaz;
        private System.Windows.Forms.Button btn_dosyasil;
        private System.Windows.Forms.Button button1;
    }
}

