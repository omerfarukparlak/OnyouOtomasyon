using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        public byte[] Photo { get; set; }
        OpenFileDialog openFile = new OpenFileDialog();
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from urunler", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["urunId"].Visible = false;
            gridView1.Columns["urunNo"].Caption = "Ürün Numarası";
            gridView1.Columns["urunNo"].MaxWidth = 85;
            gridView1.Columns["urunMarka"].Caption = "Ürün Markası";
            gridView1.Columns["urunMarka"].MaxWidth = 85;
            gridView1.Columns["urunModel"].Caption = "Ürün Modeli";
            gridView1.Columns["urunModel"].MaxWidth = 85;
            gridView1.Columns["urunTur"].Caption = "Ürün Türü";
            gridView1.Columns["urunTur"].MaxWidth = 85;
            gridView1.Columns["fiyat"].Caption = "Ürün Fiyatı";
            gridView1.Columns["fiyat"].MaxWidth = 85;
            gridView1.Columns["urunResim"].Caption = "Ürün Resmi";
            gridView1.Columns["urunResim"].MaxWidth = 85;
        }
        private void frmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "Insert into urunler(urunNo,urunMarka,urunModel,urunTur,fiyat,urunResim) " +
                            "values(@no,@marka,@model,@tur,@fiyat,@resim)";
                cmd.CommandText = sorgu;
                Photo = imageToByteArray(Image.FromFile(openFile.FileName));
                cmd.Parameters.AddWithValue("@no", txtNo.Text);
                cmd.Parameters.AddWithValue("@marka", txtMarka.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                cmd.Parameters.AddWithValue("@resim", Photo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Bilgiler kontrol ederek tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtFiyat.Text = dr["fiyat"].ToString();
            txtMarka.Text = dr["urunMarka"].ToString();
            txtModel.Text = dr["urunModel"].ToString();
            txtNo.Text = dr["urunNo"].ToString();
            cmbTur.Text = dr["urunTur"].ToString();
        }
    }
}
