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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible=true;
            label1.Text = "Bu üründe kampanya yoktur..";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Bu üründe %10 indirim vardır..";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Bu üründe kampanya yoktur..";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Bu üründe %5 indirim vardır..";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Bu üründe %5 indirim vardır..";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Bu üründe kampanya yoktur..";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }
    }
}
