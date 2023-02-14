using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmKullanıcılar : Form
    {
        public frmKullanıcılar()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Random rd = new Random();

            int rand_num = rd.Next(100000, 200000);

            txtUserCode.Text = rand_num.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = bag.baglanti();
                var sorgu = "insert into userdata(username,password,userCode)values(@user,@pass,@ucode)";
                cmd.CommandText = sorgu;
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@ucode", txtUserCode.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kaydınız tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Bilgiler kontrol ederek tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void frmKullanıcılar_Load(object sender, EventArgs e)
        {

        }
    }

}
