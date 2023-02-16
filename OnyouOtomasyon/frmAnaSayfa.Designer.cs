
namespace OnyouOtomasyon
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridMalzemeler = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridMakineler = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridPersoneller = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gridSatislar = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.gridKullanicilar = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMakineler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.gridUrunler);
            this.groupControl1.Location = new System.Drawing.Point(1089, 410);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(385, 187);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ürünler";
            // 
            // gridUrunler
            // 
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.Location = new System.Drawing.Point(2, 33);
            this.gridUrunler.MainView = this.gridView6;
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.Size = new System.Drawing.Size(381, 152);
            this.gridUrunler.TabIndex = 0;
            this.gridUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridUrunler;
            this.gridView6.Name = "gridView6";
            this.gridView6.DoubleClick += new System.EventHandler(this.gridView6_DoubleClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.gridMalzemeler);
            this.groupControl2.Location = new System.Drawing.Point(1089, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(385, 412);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Malzeme / Ekipmanlar";
            // 
            // gridMalzemeler
            // 
            this.gridMalzemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMalzemeler.Location = new System.Drawing.Point(2, 33);
            this.gridMalzemeler.MainView = this.gridView5;
            this.gridMalzemeler.Name = "gridMalzemeler";
            this.gridMalzemeler.Size = new System.Drawing.Size(381, 377);
            this.gridMalzemeler.TabIndex = 0;
            this.gridMalzemeler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridMalzemeler;
            this.gridView5.Name = "gridView5";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.gridMakineler);
            this.groupControl3.Location = new System.Drawing.Point(1, 410);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(385, 185);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Makineler";
            // 
            // gridMakineler
            // 
            this.gridMakineler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMakineler.Location = new System.Drawing.Point(2, 33);
            this.gridMakineler.MainView = this.gridView2;
            this.gridMakineler.Name = "gridMakineler";
            this.gridMakineler.Size = new System.Drawing.Size(381, 150);
            this.gridMakineler.TabIndex = 0;
            this.gridMakineler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridMakineler;
            this.gridView2.Name = "gridView2";
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImageOptions.Image")));
            this.groupControl4.Controls.Add(this.gridPersoneller);
            this.groupControl4.Location = new System.Drawing.Point(1, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(385, 412);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Personeller";
            // 
            // gridPersoneller
            // 
            this.gridPersoneller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPersoneller.Location = new System.Drawing.Point(2, 33);
            this.gridPersoneller.MainView = this.gridView1;
            this.gridPersoneller.Name = "gridPersoneller";
            this.gridPersoneller.Size = new System.Drawing.Size(381, 377);
            this.gridPersoneller.TabIndex = 0;
            this.gridPersoneller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridPersoneller;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl5.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImageOptions.Image")));
            this.groupControl5.Controls.Add(this.gridSatislar);
            this.groupControl5.Location = new System.Drawing.Point(386, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(705, 412);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "Son Satışlar";
            // 
            // gridSatislar
            // 
            this.gridSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSatislar.Location = new System.Drawing.Point(2, 33);
            this.gridSatislar.MainView = this.gridView3;
            this.gridSatislar.Name = "gridSatislar";
            this.gridSatislar.Size = new System.Drawing.Size(701, 377);
            this.gridSatislar.TabIndex = 0;
            this.gridSatislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridSatislar;
            this.gridView3.Name = "gridView3";
            // 
            // groupControl6
            // 
            this.groupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl6.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl6.CaptionImageOptions.Image")));
            this.groupControl6.Controls.Add(this.gridKullanicilar);
            this.groupControl6.Location = new System.Drawing.Point(386, 410);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(705, 185);
            this.groupControl6.TabIndex = 1;
            this.groupControl6.Text = "Kullanıcı Bilgileri";
            // 
            // gridKullanicilar
            // 
            this.gridKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKullanicilar.Location = new System.Drawing.Point(2, 33);
            this.gridKullanicilar.MainView = this.gridView4;
            this.gridKullanicilar.Name = "gridKullanicilar";
            this.gridKullanicilar.Size = new System.Drawing.Size(701, 150);
            this.gridKullanicilar.TabIndex = 0;
            this.gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridKullanicilar;
            this.gridView4.Name = "gridView4";
            // 
            // frmAnaSayfa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 595);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMakineler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraGrid.GridControl gridUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.GridControl gridMalzemeler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.GridControl gridMakineler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridPersoneller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridSatislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridKullanicilar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}