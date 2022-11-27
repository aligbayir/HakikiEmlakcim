using Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakikiEmlakcim
{
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }
        MusteriManager musterimng = new MusteriManager();
        private void button1_Click(object sender, EventArgs e)
        {
            var kullanici = musterimng.Get(x=>x.MusteriTel==textBox2.Text && x.MusteriTC==textBox1.Text);
            var musid = kullanici.MusteriID;

            if (kullanici == null && kullanici.MusteriTel != textBox2.Text && kullanici.MusteriTC != textBox1.Text)
            {
                MessageBox.Show("Telefon Numaranız Veya Tc Niz hatalı");
            }
            else
            {
                MessageBox.Show("HG Kral");
                MusteriIlanYonetim yonetimForm = new MusteriIlanYonetim(musid);
                yonetimForm.Show();
                this.Hide();
            }
                
        }

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKayitForm kayit = new MusteriKayitForm();
            kayit.Show();
            this.Hide();
        }
    }
}
