using Business.Concrete;
using Entities;
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
    public partial class IlanDetailForm : Form
    {
        public int evid { get; set; }
        public int musteriid { get; set; }

        public IlanDetailForm(string id,string mid)
        {
            InitializeComponent();
            this.evid = int.Parse(id);
            this.musteriid = int.Parse(mid);
        }
        EvManager evManager = new EvManager();
        MusteriManager MusteriManager = new MusteriManager();
        public void Listele()
        {
            //Ev Bilgileri
            var sorgu = evManager.Get(x => x.evID == evid);
            textBox1.Text = sorgu.il;
            textBox2.Text = sorgu.ilce;
            textBox3.Text = sorgu.ilanTarih.ToString();
            textBox4.Text = sorgu.brütm2;
            textBox5.Text = sorgu.netm2;
            textBox6.Text = sorgu.odasayisi;
            textBox7.Text = sorgu.binayas;
            textBox8.Text = sorgu.bulundugukat;
            textBox9.Text = sorgu.binadakitoplamkat;
            textBox10.Text = sorgu.isitma;
            textBox11.Text = sorgu.banyosayisi.ToString();
            textBox12.Text = sorgu.Aidat.ToString();
            textBox13.Text = sorgu.balkondurum.ToString();
            textBox14.Text = sorgu.esyadurum.ToString();
            textBox15.Text = sorgu.siteicidurum.ToString();
            textBox16.Text = sorgu.krediyeuygunlukdurum.ToString();
            textBox17.Text = sorgu.tapucesidi.ToString();
            textBox18.Text = sorgu.takasdurum.ToString();
            textBox19.Text = sorgu.satilikdurum.ToString();
            var deneme =sorgu.tbl_evfoto.ToList();

            if (deneme.Count > 0)
            {
                pictureBox1.ImageLocation = deneme[0].url.ToString();
            }
            

            var musteri = MusteriManager.Get(x=>x.MusteriID==musteriid);

            //İletişim Bilgileri
            textBox20.Text = musteri.MusteriAd;
            textBox21.Text = musteri.MusteriSoyad;
            textBox22.Text = musteri.MusteriTel;
        }
        private void IlanForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            anaForm.Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
