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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CF2MUPA;Initial Catalog=giyim;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        string KomutString;

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr;
            komut.CommandText = "SELECT*FROM Urunler";
            adtr = new SqlDataAdapter(komut.CommandText, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle frmekle = new ekle();
            frmekle.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gömlek")
            {
                pictureBox1.Image = Properties.Resources.gömlek;
            }
            else if (comboBox1.Text == "Elbise")
            {
                pictureBox1.Image = Properties.Resources.elbise;
            }
            else if (comboBox1.Text == "Pantolon")
            {
                pictureBox1.Image = Properties.Resources.pantolon;
            }
            else if (comboBox1.Text == "Etek")
            {
                pictureBox1.Image = Properties.Resources.etek;
            }
            else if (comboBox1.Text == "Ayakkabı")
            {
                pictureBox1.Image = Properties.Resources.ayakkabı;
            }
            else if (comboBox1.Text == "Şapka")
            {
                pictureBox1.Image = Properties.Resources.sapka;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gömlek")
            {
                pictureBox1.Image = Properties.Resources.gömlek;
            }
            else if (comboBox1.Text == "Elbise")
            {
                pictureBox1.Image = Properties.Resources.elbise;
            }
            else if (comboBox1.Text == "Pantolon")
            {
                pictureBox1.Image = Properties.Resources.pantolon;
            }
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gömlek")
            {
                pictureBox1.Image = Properties.Resources.gömlek;
            }
            else if (comboBox1.Text == "Elbise")
            {
                pictureBox1.Image = Properties.Resources.elbise;
            }
            else if (comboBox1.Text == "Pantolon")
            {
                pictureBox1.Image = Properties.Resources.pantolon;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guncelle frm = new guncelle();
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
