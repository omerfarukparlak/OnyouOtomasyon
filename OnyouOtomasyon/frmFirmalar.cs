using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from firmalar", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["firmaId"].MaxWidth = 80;
            gridView1.Columns["firmaAd"].Caption = "Firma Adı";
            gridView1.Columns["firmaAd"].MaxWidth = 80;
            gridView1.Columns["yetkiliAdSoyad"].Caption = "Yetkili";
            gridView1.Columns["yetkiliAdSoyad"].MaxWidth = 100;
            gridView1.Columns["yetkiliTel1"].Caption = "Telefon 1";
            gridView1.Columns["yetkiliTel1"].MaxWidth = 80;
            gridView1.Columns["yetkiliTel2"].Caption = "Telefon 2";
            gridView1.Columns["yetkiliTel2"].MaxWidth = 80;
            gridView1.Columns["firmaMail"].Caption = "Mail";
            gridView1.Columns["firmaMail"].MaxWidth = 120;
            gridView1.Columns["firmaVergiNo"].Caption = "Vergi Numarası";
            gridView1.Columns["firmaVergiNo"].MaxWidth = 80;
            gridView1.Columns["firmaAdres"].Caption = "Adres";
            gridView1.Columns["firmaAdres"].MaxWidth = 80;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "Insert into firmalar(firmaAd,yetkiliAdSoyad,yetkiliTel1,yetkiliTel2,firmaMail,firmaVergiNo,firmaAdres)" +
                    " values(@ad,@yetkili,@ytel1,ytel2,@mail,@vergino,@adres)";
                cmd.CommandText = sorgu;
                cmd.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
                cmd.Parameters.AddWithValue("@yetkili", txtYetkili.Text);
                cmd.Parameters.AddWithValue("@ytel1", txtTel1.Text);
                cmd.Parameters.AddWithValue("@ytel2", txtTel2.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@vergino", txtVergiNo.Text);
                cmd.Parameters.AddWithValue("@adres", rchAdres.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Firma başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Bilgiler kontrol ederek tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtFirmaAd.Text = dr["firmaAd"].ToString();
            txtMail.Text = dr["firmaMail"].ToString();
            txtTel1.Text = dr["yetkiliTel1"].ToString();
            txtTel2.Text = dr["yetkiliTel2"].ToString();
            txtVergiNo.Text = dr["firmaVergiNo"].ToString();
            rchAdres.Text = dr["firmaAdres"].ToString();
            txtYetkili.Text = dr["yetkiliAdSoyad"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                cmd.Connection = bag.baglanti();
                var sorgu = "update firmalar set firmaAd=@ad,firmaMail=@mail,yetkiliTel1=@tel1,yetkiliTel2=@tel2,firmaVergiNo=@vergi,firmaAdres=@adres,yetkiliAdSoyad=@adsoyad where firmaId=@id"; ;
                cmd.CommandText = sorgu;
                cmd.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@tel1", txtTel1.Text);
                cmd.Parameters.AddWithValue("@tel2", txtTel2.Text);
                cmd.Parameters.AddWithValue("@vergi", txtVergiNo.Text);
                cmd.Parameters.AddWithValue("@adres", rchAdres.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtYetkili.Text);
                cmd.Parameters.AddWithValue("@id", dr["firmaId"].ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarıyla tamamlandı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen bilgileri kontrol ederek tekrar deneyiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
            

        }
    }
}
