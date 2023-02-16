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
    public partial class frmUrunBilgi : Form
    {
        public frmUrunBilgi()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        public string urunNo;
        public string urunMarka;
        public string urunModel;
        public string urunTur;
        public string urunFiyat;
        private void frmUrunBilgi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT urunResim FROM urunler", bag.baglanti()));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["urunResim"]);
                MemoryStream mem = new MemoryStream(data);
                pictureUrun.Image = Image.FromStream(mem);
            }
            frmAnaSayfa anaSayfa = new frmAnaSayfa();
            lblUrunMarka.Text = "Ürün Markası: " + urunMarka;
            lblUrunFiyat.Text = "Ürün Modeli: " + urunModel;
            lbUrunlModel.Text = "Ürün Türü: " + urunTur;
            lblUrunTur.Text = "Ürün Fiyatı: " + urunFiyat;
            lblUrunNo.Text = "Ürün Numarası: " + urunNo;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
