using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient

namespace okul_yonetim
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            
        }
        void ogrencigetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=okul;Integrated Security=SSPI\"");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci ogrencifrm= new ogrenci();
            ogrencifrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetim yonetimfrm = new yonetim();
            yonetimfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ders dersfrm = new ders();
            dersfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrders ogrencidersfrm = new ogrders();
            ogrencidersfrm.Show();
        }
    }
}
