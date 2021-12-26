using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="kubrashn" && textBox2.Text=="12345")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else if (textBox1.Text=="esmasvd" && textBox2.Text=="1234")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else if (textBox1.Text == "humeysa" && textBox2.Text == "123")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("Yanlış yönetici adı veya şifre girdiniz", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            this.Hide();

        }
    }
}
