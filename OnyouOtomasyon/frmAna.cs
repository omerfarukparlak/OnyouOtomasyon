using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmAna : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAna()
        {
            InitializeComponent();
        }
        frmPersoneller personel;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personel = new frmPersoneller();
            personel.MdiParent = this;
            personel.Show();
        }
        frmFirmalar firma;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firma = new frmFirmalar();
            firma.MdiParent = this;
            firma.Show();
        }
        frmMakineler makine;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            makine = new frmMakineler();
            makine.MdiParent = this;
            makine.Show();
        }
        frmUrunler urun;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            urun = new frmUrunler();
            urun.MdiParent = this;
            urun.Show();
        }

        private void frmAna_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
        frmMalzemeler malzeme;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            malzeme = new frmMalzemeler();
            malzeme.MdiParent = this;
            malzeme.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
        frmKullanıcılar kullanicilar;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kullanicilar = new frmKullanıcılar();
            kullanicilar.ShowDialog();
        }
        frmSatislar satis;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            satis = new frmSatislar();
            satis.MdiParent = this;
            satis.Show();
        }

        private void ribbonControl1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
