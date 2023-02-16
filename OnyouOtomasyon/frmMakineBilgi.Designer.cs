
namespace OnyouOtomasyon
{
    partial class frmMakineBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakineBilgi));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureMakine = new System.Windows.Forms.PictureBox();
            this.lblMakineMarka = new DevExpress.XtraEditors.LabelControl();
            this.lblMakineModel = new DevExpress.XtraEditors.LabelControl();
            this.lblMakineDurum = new DevExpress.XtraEditors.LabelControl();
            this.lblMakineTur = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMakine)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(464, 284);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 38);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Tamam";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureMakine
            // 
            this.pictureMakine.Location = new System.Drawing.Point(12, 12);
            this.pictureMakine.Name = "pictureMakine";
            this.pictureMakine.Size = new System.Drawing.Size(226, 310);
            this.pictureMakine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMakine.TabIndex = 0;
            this.pictureMakine.TabStop = false;
            // 
            // lblMakineMarka
            // 
            this.lblMakineMarka.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakineMarka.Appearance.Options.UseFont = true;
            this.lblMakineMarka.Location = new System.Drawing.Point(253, 47);
            this.lblMakineMarka.Name = "lblMakineMarka";
            this.lblMakineMarka.Size = new System.Drawing.Size(174, 25);
            this.lblMakineMarka.TabIndex = 2;
            this.lblMakineMarka.Text = "Makine Markası:";
            // 
            // lblMakineModel
            // 
            this.lblMakineModel.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakineModel.Appearance.Options.UseFont = true;
            this.lblMakineModel.Location = new System.Drawing.Point(253, 100);
            this.lblMakineModel.Name = "lblMakineModel";
            this.lblMakineModel.Size = new System.Drawing.Size(159, 25);
            this.lblMakineModel.TabIndex = 3;
            this.lblMakineModel.Text = "Makine Modeli:";
            // 
            // lblMakineDurum
            // 
            this.lblMakineDurum.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakineDurum.Appearance.Options.UseFont = true;
            this.lblMakineDurum.Location = new System.Drawing.Point(253, 206);
            this.lblMakineDurum.Name = "lblMakineDurum";
            this.lblMakineDurum.Size = new System.Drawing.Size(174, 25);
            this.lblMakineDurum.TabIndex = 5;
            this.lblMakineDurum.Text = "Makine Durumu:";
            // 
            // lblMakineTur
            // 
            this.lblMakineTur.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakineTur.Appearance.Options.UseFont = true;
            this.lblMakineTur.Location = new System.Drawing.Point(253, 155);
            this.lblMakineTur.Name = "lblMakineTur";
            this.lblMakineTur.Size = new System.Drawing.Size(138, 25);
            this.lblMakineTur.TabIndex = 4;
            this.lblMakineTur.Text = "Makine Türü:";
            // 
            // frmMakineBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 334);
            this.Controls.Add(this.lblMakineDurum);
            this.Controls.Add(this.lblMakineTur);
            this.Controls.Add(this.lblMakineModel);
            this.Controls.Add(this.lblMakineMarka);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureMakine);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMakineBilgi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Makine Bilgisi";
            this.Load += new System.EventHandler(this.frmMakineBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMakine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMakine;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblMakineMarka;
        private DevExpress.XtraEditors.LabelControl lblMakineModel;
        private DevExpress.XtraEditors.LabelControl lblMakineDurum;
        private DevExpress.XtraEditors.LabelControl lblMakineTur;
    }
}