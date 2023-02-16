
namespace OnyouOtomasyon
{
    partial class frmUrunBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunBilgi));
            this.lblUrunFiyat = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunTur = new DevExpress.XtraEditors.LabelControl();
            this.lbUrunlModel = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunMarka = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureUrun = new System.Windows.Forms.PictureBox();
            this.lblUrunNo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyat.Appearance.Options.UseFont = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(269, 238);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(123, 25);
            this.lblUrunFiyat.TabIndex = 11;
            this.lblUrunFiyat.Text = "Ürün Fiyatı:";
            // 
            // lblUrunTur
            // 
            this.lblUrunTur.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTur.Appearance.Options.UseFont = true;
            this.lblUrunTur.Location = new System.Drawing.Point(269, 187);
            this.lblUrunTur.Name = "lblUrunTur";
            this.lblUrunTur.Size = new System.Drawing.Size(113, 25);
            this.lblUrunTur.TabIndex = 10;
            this.lblUrunTur.Text = "Ürün Türü:";
            // 
            // lbUrunlModel
            // 
            this.lbUrunlModel.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunlModel.Appearance.Options.UseFont = true;
            this.lbUrunlModel.Location = new System.Drawing.Point(269, 132);
            this.lbUrunlModel.Name = "lbUrunlModel";
            this.lbUrunlModel.Size = new System.Drawing.Size(134, 25);
            this.lbUrunlModel.TabIndex = 9;
            this.lbUrunlModel.Text = "Ürün Modeli:";
            // 
            // lblUrunMarka
            // 
            this.lblUrunMarka.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMarka.Appearance.Options.UseFont = true;
            this.lblUrunMarka.Location = new System.Drawing.Point(269, 79);
            this.lblUrunMarka.Name = "lblUrunMarka";
            this.lblUrunMarka.Size = new System.Drawing.Size(149, 25);
            this.lblUrunMarka.TabIndex = 8;
            this.lblUrunMarka.Text = "Ürün Markası:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(568, 279);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 38);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Tamam";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureUrun
            // 
            this.pictureUrun.Location = new System.Drawing.Point(12, 12);
            this.pictureUrun.Name = "pictureUrun";
            this.pictureUrun.Size = new System.Drawing.Size(239, 299);
            this.pictureUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUrun.TabIndex = 6;
            this.pictureUrun.TabStop = false;
            // 
            // lblUrunNo
            // 
            this.lblUrunNo.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunNo.Appearance.Options.UseFont = true;
            this.lblUrunNo.Location = new System.Drawing.Point(269, 27);
            this.lblUrunNo.Name = "lblUrunNo";
            this.lblUrunNo.Size = new System.Drawing.Size(166, 25);
            this.lblUrunNo.TabIndex = 12;
            this.lblUrunNo.Text = "Ürün Numarası:";
            // 
            // frmUrunBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 323);
            this.Controls.Add(this.lblUrunNo);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunTur);
            this.Controls.Add(this.lbUrunlModel);
            this.Controls.Add(this.lblUrunMarka);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureUrun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunBilgi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgisi";
            this.Load += new System.EventHandler(this.frmUrunBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUrunFiyat;
        private DevExpress.XtraEditors.LabelControl lblUrunTur;
        private DevExpress.XtraEditors.LabelControl lbUrunlModel;
        private DevExpress.XtraEditors.LabelControl lblUrunMarka;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureUrun;
        private DevExpress.XtraEditors.LabelControl lblUrunNo;
    }
}