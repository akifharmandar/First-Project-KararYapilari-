namespace KararYapilariProject
{
    partial class ÖDEV1
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
            this.lblRastgele = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanHakkimiz = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lütfen aşağıda görmüş karakterleri ilgili yazı alanına geçiriniz:";
            // 
            // lblRastgele
            // 
            this.lblRastgele.AutoSize = true;
            this.lblRastgele.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblRastgele.Location = new System.Drawing.Point(41, 84);
            this.lblRastgele.Name = "lblRastgele";
            this.lblRastgele.Size = new System.Drawing.Size(36, 19);
            this.lblRastgele.TabIndex = 14;
            this.lblRastgele.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kalan Hatalı Giriş Hakkınız:";
            // 
            // lblKalanHakkimiz
            // 
            this.lblKalanHakkimiz.AutoSize = true;
            this.lblKalanHakkimiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblKalanHakkimiz.ForeColor = System.Drawing.Color.Maroon;
            this.lblKalanHakkimiz.Location = new System.Drawing.Point(290, 197);
            this.lblKalanHakkimiz.Name = "lblKalanHakkimiz";
            this.lblKalanHakkimiz.Size = new System.Drawing.Size(19, 18);
            this.lblKalanHakkimiz.TabIndex = 18;
            this.lblKalanHakkimiz.Text = "5";
            this.lblKalanHakkimiz.Click += new System.EventHandler(this.lblKalanHakkimiz_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(310, 124);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(178, 32);
            this.btnGirisYap.TabIndex = 19;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(45, 136);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(200, 20);
            this.txtGiris.TabIndex = 20;
            this.txtGiris.TextChanged += new System.EventHandler(this.txtGiris_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblKalanHakkimiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRastgele);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRastgele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanHakkimiz;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtGiris;
    }
}