namespace OperatorZaman
{
    partial class Form1
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
            this.Txt_TimeH1 = new System.Windows.Forms.TextBox();
            this.Txt_TimeM1 = new System.Windows.Forms.TextBox();
            this.Txt_TimeS1 = new System.Windows.Forms.TextBox();
            this.Txt_TimeS2 = new System.Windows.Forms.TextBox();
            this.Txt_TimeM2 = new System.Windows.Forms.TextBox();
            this.Txt_TimeH2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_Toplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_TimeH1
            // 
            this.Txt_TimeH1.Location = new System.Drawing.Point(67, 6);
            this.Txt_TimeH1.Name = "Txt_TimeH1";
            this.Txt_TimeH1.Size = new System.Drawing.Size(20, 20);
            this.Txt_TimeH1.TabIndex = 0;
            // 
            // Txt_TimeM1
            // 
            this.Txt_TimeM1.Location = new System.Drawing.Point(93, 6);
            this.Txt_TimeM1.Name = "Txt_TimeM1";
            this.Txt_TimeM1.Size = new System.Drawing.Size(20, 20);
            this.Txt_TimeM1.TabIndex = 1;
            // 
            // Txt_TimeS1
            // 
            this.Txt_TimeS1.Location = new System.Drawing.Point(119, 6);
            this.Txt_TimeS1.Name = "Txt_TimeS1";
            this.Txt_TimeS1.Size = new System.Drawing.Size(20, 20);
            this.Txt_TimeS1.TabIndex = 2;
            // 
            // Txt_TimeS2
            // 
            this.Txt_TimeS2.Location = new System.Drawing.Point(119, 32);
            this.Txt_TimeS2.Name = "Txt_TimeS2";
            this.Txt_TimeS2.Size = new System.Drawing.Size(20, 20);
            this.Txt_TimeS2.TabIndex = 5;
            // 
            // Txt_TimeM2
            // 
            this.Txt_TimeM2.Location = new System.Drawing.Point(93, 32);
            this.Txt_TimeM2.Name = "Txt_TimeM2";
            this.Txt_TimeM2.Size = new System.Drawing.Size(20, 20);
            this.Txt_TimeM2.TabIndex = 4;
            // 
            // Txt_TimeH2
            // 
            this.Txt_TimeH2.Location = new System.Drawing.Point(67, 32);
            this.Txt_TimeH2.Name = "Txt_TimeH2";
            this.Txt_TimeH2.Size = new System.Drawing.Size(20, 20);
            this.Txt_TimeH2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.Zaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2.Zaman";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Topla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Toplam
            // 
            this.Lbl_Toplam.AutoSize = true;
            this.Lbl_Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Toplam.Location = new System.Drawing.Point(11, 55);
            this.Lbl_Toplam.Name = "Lbl_Toplam";
            this.Lbl_Toplam.Size = new System.Drawing.Size(65, 20);
            this.Lbl_Toplam.TabIndex = 9;
            this.Lbl_Toplam.Text = "Toplam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 80);
            this.Controls.Add(this.Lbl_Toplam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_TimeS2);
            this.Controls.Add(this.Txt_TimeM2);
            this.Controls.Add(this.Txt_TimeH2);
            this.Controls.Add(this.Txt_TimeS1);
            this.Controls.Add(this.Txt_TimeM1);
            this.Controls.Add(this.Txt_TimeH1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_TimeH1;
        private System.Windows.Forms.TextBox Txt_TimeM1;
        private System.Windows.Forms.TextBox Txt_TimeS1;
        private System.Windows.Forms.TextBox Txt_TimeS2;
        private System.Windows.Forms.TextBox Txt_TimeM2;
        private System.Windows.Forms.TextBox Txt_TimeH2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_Toplam;
    }
}

