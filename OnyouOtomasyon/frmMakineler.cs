using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmMakineler : Form
    {
        public frmMakineler()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        public byte[] Photo { get; set; }
        OpenFileDialog openFile = new OpenFileDialog();
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from makineler", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["makineId"].Visible = false;
            gridView1.Columns["makineMarka"].Caption = "Marka";
            gridView1.Columns["makineMarka"].MaxWidth = 80;
            gridView1.Columns["makineModel"].Caption = "Model";
            gridView1.Columns["makineModel"].MaxWidth = 80;
            gridView1.Columns["makineTur"].Caption = "Tür";
            gridView1.Columns["makineTur"].MaxWidth = 80;
            gridView1.Columns["makineDurum"].Caption = "Durum";
            gridView1.Columns["makineDurum"].MaxWidth = 80;
            gridView1.Columns["makineResim"].Caption = "Resim";
            gridView1.Columns["makineResim"].MaxWidth = 80;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "Insert into makineler(makineMarka,makineModel,makineTur,makineDurum,makineResim) " +
                            "values(@marka,@model,@tur,@durum,@resim)";
                cmd.CommandText = sorgu;
                Photo = imageToByteArray(Image.FromFile(openFile.FileName));
                cmd.Parameters.AddWithValue("@marka", txtMarka.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@durum", cmbDurum.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@resim", Photo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Makine başarıyla eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnYukle_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void frmMakineler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtMarka.Text = dr["makineMarka"].ToString();
            txtModel.Text = dr["makineModel"].ToString();
            cmbDurum.Text = dr["makineDurum"].ToString();
            cmbTur.Text = dr["makineTur"].ToString();
        }
    }
}
