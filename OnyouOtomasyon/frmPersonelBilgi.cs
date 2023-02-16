using System;
using System.IO;
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
    public partial class frmPersonelBilgi : Form
    {
        public frmPersonelBilgi()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        public string personelAd;
        public string personelSoyad;
        public string personelMevkii;
        public string personelTel1;
        public string personelTel2;
        public string personelAdres;
        private void frmPersonelBilgi_Load(object sender, EventArgs e)
        {
            lblAd.Text = "Adı: " + personelAd.ToString();
            lblSoyad.Text = "Soyadı: " + personelSoyad.ToString();
            lblTel1.Text = "Telefon 1: " + personelTel1.ToString();
            lblTel2.Text = "Telefon 2: " + personelTel2.ToString();
            lblMevkii.Text = "Mevkii: " + personelMevkii.ToString();
            rchAdres.Text = personelAdres.ToString();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT vesikalik FROM personeller", bag.baglanti()));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["vesikalik"]);
                MemoryStream mem = new MemoryStream(data);
                picturePersonel.Image = Image.FromStream(mem);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
