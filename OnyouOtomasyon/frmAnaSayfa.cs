using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OnyouOtomasyon
{
    public partial class frmAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        void GridMakineler()
        {
            SqlDataAdapter adtrMakine = new SqlDataAdapter("Select * from makineler", bag.baglanti());
            DataTable dtMakine = new DataTable();
            adtrMakine.Fill(dtMakine);
            gridMakineler.DataSource = dtMakine;
            gridView2.Columns["makineId"].Visible = false;
            gridView2.Columns["makineMarka"].Caption = "Marka";
            gridView2.Columns["makineModel"].Caption = "Model";
            gridView2.Columns["makineTur"].Caption = "Tür";
            gridView2.Columns["makineDurum"].Caption = "Durum";
            gridView2.Columns["makineResim"].Visible = false;
        }
        void GridUrunler()
        {
            SqlDataAdapter adtrUrun = new SqlDataAdapter("Select * from urunler", bag.baglanti());
            DataTable dtUrun = new DataTable();
            adtrUrun.Fill(dtUrun);
            gridUrunler.DataSource = dtUrun;
            gridView6.Columns["urunId"].Visible = false;
            gridView6.Columns["urunNo"].Caption = "Numara";
            gridView6.Columns["urunMarka"].Caption = "Marka";
            gridView6.Columns["urunModel"].Caption = "Model";
            gridView6.Columns["urunTur"].Caption = "Tür";
            gridView6.Columns["fiyat"].Caption = "Fiyat";
            gridView6.Columns["urunResim"].Visible = false;
        }
        void GridSatislar()
        {
            SqlDataAdapter adtrSatis = new SqlDataAdapter("Select * from satislar", bag.baglanti());
            DataTable dtSatis = new DataTable();
            adtrSatis.Fill(dtSatis);
            gridSatislar.DataSource = dtSatis;
            gridView3.Columns["satisId"].Visible = false;
            gridView3.Columns["firmaAd"].Caption = "Firma Adı";
            gridView3.Columns["urun"].Caption = "Ürün";
            gridView3.Columns["fiyat"].Caption = "Fiyat";
            gridView3.Columns["teslimAlan"].Caption = "Teslim Alan";
            gridView3.Columns["teslimEden"].Caption = "Teslim Eden";
            gridView3.Columns["satisNo"].Caption = "Satış Numarası";
            gridView3.Columns["kullanilanMalzeme"].Visible = false;
            gridView3.Columns["malzemeFiyat"].Visible = false;
            gridView3.Columns["adet"].Caption = "Adet";
        }
        void GridMalzemeler()
        {
            SqlDataAdapter adtrMalzeme = new SqlDataAdapter("Select * from malzemeler", bag.baglanti());
            DataTable dtMalzeme = new DataTable();
            adtrMalzeme.Fill(dtMalzeme);
            gridMalzemeler.DataSource = dtMalzeme;
            gridView5.Columns["malzemeId"].Visible = false;
            gridView5.Columns["malzemeMarka"].Caption = "Marka";
            gridView5.Columns["malzemeTur"].Caption = "Tür";
            gridView5.Columns["malzemeUzunluk"].Caption = "Uzunluk";
        }
        void GridKullanicilar()
        {
            SqlDataAdapter adtrKullanici = new SqlDataAdapter("Select * from userdata", bag.baglanti());
            DataTable dtKullanici = new DataTable();
            adtrKullanici.Fill(dtKullanici);
            gridKullanicilar.DataSource = dtKullanici;
            gridView4.Columns["userId"].Visible = false;
            gridView4.Columns["username"].Caption = "Kullanıcı Adı";
            gridView4.Columns["password"].Visible = false;
            gridView4.Columns["userCode"].Caption = "Kullanıcı Kodu";
        }
        void GridPersoneller()
        {
            SqlDataAdapter adtrPersonel = new SqlDataAdapter("select * from personeller", bag.baglanti());
            DataTable dtPersonel = new DataTable();
            adtrPersonel.Fill(dtPersonel);
            gridPersoneller.DataSource = dtPersonel;
            gridView1.Columns["idPersonel"].Visible = false;
            gridView1.Columns["personelAd"].Caption = "Ad";
            gridView1.Columns["personelSoyad"].Caption = "Soyad";
            gridView1.Columns["personelMevkii"].Caption = "Mevkii";
            gridView1.Columns["personelTel1"].Visible = false;
            gridView1.Columns["personelTel2"].Visible = false;
            gridView1.Columns["personelAdres"].Visible = false;
            gridView1.Columns["vesikalik"].Visible = false;
        }
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            GridKullanicilar();
            GridMalzemeler();
            GridMakineler();
            GridSatislar();
            GridUrunler();
            GridPersoneller();
        }
        
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            frmMakineBilgi makineBilgi = new frmMakineBilgi();
            makineBilgi.makineMarka = dr["makineMarka"].ToString();
            makineBilgi.makineModel = dr["makineModel"].ToString();
            makineBilgi.makineTur = dr["makineTur"].ToString();
            makineBilgi.makineDurum = dr["makineDurum"].ToString();
            makineBilgi.Show();
        }
        private void gridView6_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView6.GetDataRow(gridView6.FocusedRowHandle);
            frmUrunBilgi urunBilgi = new frmUrunBilgi();
            urunBilgi.urunMarka = dr["urunMarka"].ToString();
            urunBilgi.urunModel = dr["urunModel"].ToString();
            urunBilgi.urunTur = dr["urunTur"].ToString();
            urunBilgi.urunNo = dr["urunNo"].ToString();
            urunBilgi.urunFiyat = dr["fiyat"].ToString();
            urunBilgi.Show();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            frmPersonelBilgi personelBilgi = new frmPersonelBilgi();
            personelBilgi.personelAd = dr["personelAd"].ToString();
            personelBilgi.personelSoyad = dr["personelSoyad"].ToString();
            personelBilgi.personelMevkii = dr["personelMevkii"].ToString();
            personelBilgi.personelTel1 = dr["personelTel1"].ToString();
            personelBilgi.personelTel2 = dr["personelTel2"].ToString();
            personelBilgi.personelAdres = dr["personelAdres"].ToString();
            personelBilgi.Show();
        }
    }
}