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

namespace WindowsFormsApplication1
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CF2MUPA;Initial Catalog=giyim;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        string KomutString;

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText="INSERT INTO Urunler(Urunid,Urunadi,Cinsiyet,Marka,Renk,Fiyat,StokAdet,Beden) VALUES("+Convert.ToInt32(textBox1.Text)+",'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"',"+Convert.ToInt32(textBox6.Text)+","+Convert.ToInt32(textBox7.Text)+","+Convert.ToInt32(textBox8.Text)+")";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt işlemi başarılı", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

    }
}
