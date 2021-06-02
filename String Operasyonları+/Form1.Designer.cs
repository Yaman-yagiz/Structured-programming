namespace String_Operasyonları
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
            this.BtnStringSplit = new System.Windows.Forms.Button();
            this.BtnSubstring = new System.Windows.Forms.Button();
            this.BtnArrayString = new System.Windows.Forms.Button();
            this.BtnStringReverse = new System.Windows.Forms.Button();
            this.BtnStringReverse2 = new System.Windows.Forms.Button();
            this.BtnStringCompare = new System.Windows.Forms.Button();
            this.BtnStringNull = new System.Windows.Forms.Button();
            this.BtnStringDongu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStringSplit
            // 
            this.BtnStringSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStringSplit.Location = new System.Drawing.Point(12, 77);
            this.BtnStringSplit.Name = "BtnStringSplit";
            this.BtnStringSplit.Size = new System.Drawing.Size(263, 60);
            this.BtnStringSplit.TabIndex = 1;
            this.BtnStringSplit.Text = "String Split";
            this.BtnStringSplit.UseVisualStyleBackColor = true;
            this.BtnStringSplit.Click += new System.EventHandler(this.BtnStringSplit_Click);
            // 
            // BtnSubstring
            // 
            this.BtnSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSubstring.Location = new System.Drawing.Point(12, 143);
            this.BtnSubstring.Name = "BtnSubstring";
            this.BtnSubstring.Size = new System.Drawing.Size(263, 60);
            this.BtnSubstring.TabIndex = 2;
            this.BtnSubstring.Text = "String Substring";
            this.BtnSubstring.UseVisualStyleBackColor = true;
            this.BtnSubstring.Click += new System.EventHandler(this.BtnSubstring_Click);
            // 
            // BtnArrayString
            // 
            this.BtnArrayString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArrayString.Location = new System.Drawing.Point(12, 209);
            this.BtnArrayString.Name = "BtnArrayString";
            this.BtnArrayString.Size = new System.Drawing.Size(263, 58);
            this.BtnArrayString.TabIndex = 3;
            this.BtnArrayString.Text = "String Array";
            this.BtnArrayString.UseVisualStyleBackColor = true;
            this.BtnArrayString.Click += new System.EventHandler(this.BtnArrayString_Click);
            // 
            // BtnStringReverse
            // 
            this.BtnStringReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStringReverse.Location = new System.Drawing.Point(12, 273);
            this.BtnStringReverse.Name = "BtnStringReverse";
            this.BtnStringReverse.Size = new System.Drawing.Size(263, 62);
            this.BtnStringReverse.TabIndex = 4;
            this.BtnStringReverse.Text = "String Reverse";
            this.BtnStringReverse.UseVisualStyleBackColor = true;
            this.BtnStringReverse.Click += new System.EventHandler(this.BtnStringReverse_Click);
            // 
            // BtnStringReverse2
            // 
            this.BtnStringReverse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStringReverse2.Location = new System.Drawing.Point(12, 341);
            this.BtnStringReverse2.Name = "BtnStringReverse2";
            this.BtnStringReverse2.Size = new System.Drawing.Size(263, 62);
            this.BtnStringReverse2.TabIndex = 5;
            this.BtnStringReverse2.Text = "String Reverse 2";
            this.BtnStringReverse2.UseVisualStyleBackColor = true;
            this.BtnStringReverse2.Click += new System.EventHandler(this.BtnStringReverse2_Click);
            // 
            // BtnStringCompare
            // 
            this.BtnStringCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStringCompare.Location = new System.Drawing.Point(12, 409);
            this.BtnStringCompare.Name = "BtnStringCompare";
            this.BtnStringCompare.Size = new System.Drawing.Size(263, 60);
            this.BtnStringCompare.TabIndex = 6;
            this.BtnStringCompare.Text = "String Compare";
            this.BtnStringCompare.UseVisualStyleBackColor = true;
            this.BtnStringCompare.Click += new System.EventHandler(this.BtnStringCompare_Click);
            // 
            // BtnStringNull
            // 
            this.BtnStringNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStringNull.Location = new System.Drawing.Point(12, 475);
            this.BtnStringNull.Name = "BtnStringNull";
            this.BtnStringNull.Size = new System.Drawing.Size(263, 57);
            this.BtnStringNull.TabIndex = 7;
            this.BtnStringNull.Text = "String NULL";
            this.BtnStringNull.UseVisualStyleBackColor = true;
            this.BtnStringNull.Click += new System.EventHandler(this.BtnStringNull_Click);
            // 
            // BtnStringDongu
            // 
            this.BtnStringDongu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStringDongu.Location = new System.Drawing.Point(12, 12);
            this.BtnStringDongu.Name = "BtnStringDongu";
            this.BtnStringDongu.Size = new System.Drawing.Size(263, 59);
            this.BtnStringDongu.TabIndex = 8;
            this.BtnStringDongu.Text = "String Döngü";
            this.BtnStringDongu.UseVisualStyleBackColor = true;
            this.BtnStringDongu.Click += new System.EventHandler(this.BtnStringDongu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 544);
            this.Controls.Add(this.BtnStringDongu);
            this.Controls.Add(this.BtnStringNull);
            this.Controls.Add(this.BtnStringCompare);
            this.Controls.Add(this.BtnStringReverse2);
            this.Controls.Add(this.BtnStringReverse);
            this.Controls.Add(this.BtnArrayString);
            this.Controls.Add(this.BtnSubstring);
            this.Controls.Add(this.BtnStringSplit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnStringSplit;
        private System.Windows.Forms.Button BtnSubstring;
        private System.Windows.Forms.Button BtnArrayString;
        private System.Windows.Forms.Button BtnStringReverse;
        private System.Windows.Forms.Button BtnStringReverse2;
        private System.Windows.Forms.Button BtnStringCompare;
        private System.Windows.Forms.Button BtnStringNull;
        private System.Windows.Forms.Button BtnStringDongu;
    }
}

