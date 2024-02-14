namespace UyariMesaji1
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
            this.btnUyariMesaji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyariMesaji
            // 
            this.btnUyariMesaji.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUyariMesaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyariMesaji.Location = new System.Drawing.Point(106, 61);
            this.btnUyariMesaji.Name = "btnUyariMesaji";
            this.btnUyariMesaji.Size = new System.Drawing.Size(136, 56);
            this.btnUyariMesaji.TabIndex = 0;
            this.btnUyariMesaji.Text = "Mesajı Göster";
            this.btnUyariMesaji.UseVisualStyleBackColor = false;
            this.btnUyariMesaji.Click += new System.EventHandler(this.btnUyariMesaji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 196);
            this.Controls.Add(this.btnUyariMesaji);
            this.Name = "Form1";
            this.Text = "Biligilendirme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUyariMesaji;
    }
}

