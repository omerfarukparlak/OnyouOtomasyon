using System.Data.SqlClient;
namespace OnyouOtomasyon
{
    public class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection bag = new SqlConnection("Data Source=OMERPARLAK\\SQLEXPRESS01;Initial Catalog=D:\\VERITABANı\\ONYOUOTOMASYON.MDF;Integrated Security=True");
            bag.Open();
            return bag;
        }
    }
}
