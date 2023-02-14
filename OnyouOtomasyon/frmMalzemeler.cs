using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmMalzemeler : Form
    {
        public frmMalzemeler()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from malzemeler", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["malzemeId"].Visible = false;
            gridView1.Columns["malzemeMarka"].Caption = "Marka";
            gridView1.Columns["malzemeMarka"].MaxWidth = 100;
            gridView1.Columns["malzemeTur"].Caption = "Tür";
            gridView1.Columns["malzemeTur"].MaxWidth = 100;
            gridView1.Columns["malzemeUzunluk"].Caption = "Uzunluk";
            gridView1.Columns["malzemeUzunluk"].MaxWidth = 100;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "Insert into malzemeler(malzemeMarka,malzemeTur,malzemeUzunluk) " +
                            "values(@marka,@tur,@uzunluk)";
                cmd.CommandText = sorgu;
                cmd.Parameters.AddWithValue("@marka", txtMarka.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@uzunluk", txtUzunluk.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Malzeme başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Bilgiler kontrol ederek tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void frmMalzemeler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtMarka.Text = dr["malzemeMarka"].ToString();
            txtUzunluk.Text = dr["MalzemeUzunluk"].ToString();
            cmbTur.Text = dr["malzemeTur"].ToString();
        }
    }
}
