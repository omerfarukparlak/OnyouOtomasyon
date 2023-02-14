using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OnyouOtomasyon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        SqlCommand cmd = new SqlCommand();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var sorgu = "select * from userdata where username=@user and password=@pass";
            cmd.Connection = bag.baglanti();
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            cmd.CommandText = sorgu;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmAna anaform = new frmAna();
                anaform.Show();
                this.Hide();
                dr.Close();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
