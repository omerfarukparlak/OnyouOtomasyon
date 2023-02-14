using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OnyouOtomasyon
{
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        OpenFileDialog openFile = new OpenFileDialog();
        public byte[] Photo { get; set; }
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from personeller", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["idPersonel"].MaxWidth = 60;
            gridView1.Columns["personelAd"].Caption = "Personel Adı";
            gridView1.Columns["personelAd"].MaxWidth = 60;
            gridView1.Columns["personelSoyad"].Caption = "Personel Soyadı";
            gridView1.Columns["personelSoyad"].MaxWidth = 60;
            gridView1.Columns["personelMevkii"].Caption = "Mevkii";
            gridView1.Columns["personelMevkii"].MaxWidth = 85;
            gridView1.Columns["personelTel1"].Caption = "Telefon 1";
            gridView1.Columns["personelTel1"].MaxWidth = 75;
            gridView1.Columns["personelTel2"].Caption = "Telefon 2";
            gridView1.Columns["personelTel2"].MaxWidth = 75;
            gridView1.Columns["personelAdres"].Caption = "Adres";
            gridView1.Columns["personelAdres"].MaxWidth = 60;
            gridView1.Columns["vesikalik"].MaxWidth = 85;
            gridView1.Columns["vesikalik"].Caption = "Resim";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "Insert into personeller(personelAd,personelSoyad,personelMevkii,personelTel1,personelTel2," +
                    "personelAdres,vesikalik) values(@ad,@soyad,@mevkii,@tel1,@tel2,@adres,@vesikalik)";
                cmd.CommandText = sorgu;
                Photo = imageToByteArray(Image.FromFile(openFile.FileName));
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@mevkii", txtMevkii.Text);
                cmd.Parameters.AddWithValue("@tel1", txtTel1.Text);
                cmd.Parameters.AddWithValue("@tel2", txtTel2.Text);
                cmd.Parameters.AddWithValue("@adres", rchAdres.Text);
                cmd.Parameters.AddWithValue("@vesikalik", Photo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Bilgiler kontrol ederek tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtAd.Text = dr["personelAd"].ToString();
            txtMevkii.Text = dr["personelMevkii"].ToString();
            txtSoyad.Text = dr["personelSoyad"].ToString();
            txtTel1.Text = dr["personelTel1"].ToString();
            txtTel2.Text = dr["personelTel2"].ToString();
            rchAdres.Text = dr["personelAdres"].ToString();
        }
    }
}
