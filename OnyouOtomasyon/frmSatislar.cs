using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from satislar", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["satisId"].Visible = false;
            gridView1.Columns["firmaAd"].Caption = "Firma";
            gridView1.Columns["firmaAd"].MaxWidth = 85;
            gridView1.Columns["urun"].Caption = "Ürün";
            gridView1.Columns["urun"].MaxWidth = 85;
            gridView1.Columns["fiyat"].Caption = "Fiyat";
            gridView1.Columns["fiyat"].MaxWidth = 85;
            gridView1.Columns["teslimAlan"].Caption = "Teslim Alan";
            gridView1.Columns["teslimAlan"].MaxWidth = 85;
            gridView1.Columns["teslimEden"].Caption = "Teslim Eden";
            gridView1.Columns["teslimEden"].MaxWidth = 85;
            gridView1.Columns["tarih"].Caption = "Tarih";
            gridView1.Columns["tarih"].MaxWidth = 120;
            gridView1.Columns["satisNo"].Caption = "Satış Numarası";
            gridView1.Columns["satisNo"].MaxWidth = 85;
            gridView1.Columns["kullanilanMalzeme"].Caption = "Kullanılan Malzeme";
            gridView1.Columns["kullanilanMalzeme"].MaxWidth = 85;
            gridView1.Columns["malzemeFiyat"].Caption = "Malzeme Fiyatı";
            gridView1.Columns["malzemeFiyat"].MaxWidth = 85;
        }
        private void frmSatislar_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtFirmaAd.Text = dr["firmaAd"].ToString();
            txtTeslimAlan.Text = dr["teslimAlan"].ToString();
            txtTutar.Text = dr["fiyat"].ToString();
            txtKullMalz.Text = dr["kullanilanMalzeme"].ToString();
            txtMalzFiyat.Text = dr["malzemeFiyat"].ToString();
            txtUrun.Text = dr["urun"].ToString();
            txtTeslimEden.Text = dr["teslimEden"].ToString();
            txtSatisNo.Text = dr["satisNo"].ToString();
            dateTarih.Text = dr["tarih"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Random rd = new Random();

            int rand_num = rd.Next(100000, 200000);

            txtSatisNo.Text = rand_num.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "Insert into satislar(firmaAd,urun,fiyat,teslimAlan,teslimEden,tarih,satisNo,kullanilanMalzeme,malzemefiyat,adet) " +
                            "values(@ad,@urun,@fiyat,@teslimalan,@teslimeden,@tarih,@satisno,@kullmalz,@malzfiyat,@adet)";
                cmd.CommandText = sorgu;
                cmd.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
                cmd.Parameters.AddWithValue("@urun", txtUrun.Text);
                cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtTutar.Text));
                cmd.Parameters.AddWithValue("@teslimalan", txtTeslimAlan.Text);
                cmd.Parameters.AddWithValue("@teslimeden", txtTeslimEden.Text);
                cmd.Parameters.AddWithValue("@tarih", dateTarih.Text.ToString());
                cmd.Parameters.AddWithValue("@satisno", txtSatisNo.Text.ToString());
                cmd.Parameters.AddWithValue("@kullmalz", txtKullMalz.Text.ToString());
                cmd.Parameters.AddWithValue("@malzfiyat", Convert.ToDecimal(txtMalzFiyat.Text));
                cmd.Parameters.AddWithValue("@adet", numericUpDown1.Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem tamamlandı.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Bilgiler kontrol ederek tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
