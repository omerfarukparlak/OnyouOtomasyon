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
    public partial class frmKullaniciYonet : Form
    {
        public frmKullaniciYonet()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        void Listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select username, userCode from userdata", bag.baglanti());
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["username"].Caption = "Kullanıcı Adı";
            gridView1.Columns["userCode"].Caption = "Kullanıcı Kodu";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKullaniciYonet_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmChangeUsername changeUsername = new frmChangeUsername();
            changeUsername.ShowDialog();
        }
    }
}
