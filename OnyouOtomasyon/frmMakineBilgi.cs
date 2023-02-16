using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnyouOtomasyon
{
    public partial class frmMakineBilgi : Form
    {
        public frmMakineBilgi()
        {
            InitializeComponent();
        }
        sqlBaglanti bag = new sqlBaglanti();
        public string makineMarka;
        public string makineModel;
        public string makineTur;
        public string makineDurum;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMakineBilgi frmMakineBilgi = new frmMakineBilgi();
            this.Close();
        }
        private void frmMakineBilgi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT makineResim FROM makineler", bag.baglanti()));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["makineResim"]);
                MemoryStream mem = new MemoryStream(data);
                pictureMakine.Image = Image.FromStream(mem);
            }
            frmAnaSayfa anaSayfa = new frmAnaSayfa();
            lblMakineMarka.Text = "Makine Markası: " + makineMarka;
            lblMakineDurum.Text = "Makine Durumu: " + makineDurum;
            lblMakineModel.Text = "Makine Modeli: " + makineModel;
            lblMakineTur.Text = "Makine Türü: " + makineTur;
        }
    }
}
