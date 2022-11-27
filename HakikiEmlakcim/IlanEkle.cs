using Business.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakikiEmlakcim
{
    public partial class IlanEkle : Form
    {
        public string fotourl { get; set; }
        public int musteriid { get; set; }
        public int evid { get; set; }
        public IlanEkle(int musid,int evId)
        {
            InitializeComponent();
            this.musteriid = musid;
            this.evid = evId;
        }
        public IlanEkle(int musid)
        {
            InitializeComponent();
            this.musteriid = musid;
        }
        public IlanEkle(string foto)
        {
            InitializeComponent();
            this.fotourl = foto;
        }
        IlanManager ilanmanager = new IlanManager();
        EvManager evmanager = new EvManager();
        EvFotoManager evFotoManager = new EvFotoManager();
        
        private void button1_Click(object sender, EventArgs e)
        {
            tbl_ev ev = new tbl_ev();
            ev.il = textBox1.Text;
            ev.ilce = textBox2.Text;
            ev.ilanTarih= DateTime.Now;
            ev.brütm2 = textBox3.Text;
            ev.netm2 = textBox4.Text;
            ev.odasayisi = comboBox1.Text;
            ev.binayas = textBox5.Text;
            ev.bulundugukat = textBox6.Text;
            ev.binadakitoplamkat = textBox7.Text;
            ev.isitma = comboBox2.Text;
            ev.banyosayisi = int.Parse(textBox8.Text);
            ev.Aidat = int.Parse(textBox9.Text);
            ev.balkondurum = comboBox3.Text == "Var" ? true : false;
            ev.esyadurum = comboBox4.Text == "Evet" ? true : false;
            ev.siteicidurum = comboBox5.Text == "Evet" ? true : false;
            ev.krediyeuygunlukdurum = comboBox6.Text == "Evet" ? true : false;
            ev.tapucesidi = true;
            ev.takasdurum = comboBox8.Text == "Olur" ? true : false;
            ev.satilikdurum = comboBox9.Text == "Satılık" ? true : false;
            evmanager.Add(ev);

            Thread.Sleep(500);
            tbl_ilan ilan = new tbl_ilan();
            var evid = evmanager.GetAll().Last().evID;
            ilan.evID = evid;
            ilan.musteriID = musteriid;
            ilan.Baslik = textBox10.Text;
            ilanmanager.Add(ilan);
            Thread.Sleep(500);

            tbl_evfoto evfoto = new tbl_evfoto();
            evfoto.evID= evid;
            evfoto.url = textBox11.Text;
            evFotoManager.Add(evfoto);
            Thread.Sleep(500);
            MessageBox.Show("İlan Başarıyla Oluşturuldu.");
            MusteriIlanYonetim ilanyonform = new MusteriIlanYonetim(musteriid);
            ilanyonform.Show();
            this.Hide();
        }

        private void IlanEkle_Load(object sender, EventArgs e)
        {
            IlanManager ILAN = new IlanManager();
            EvFotoManager fotomng = new EvFotoManager();
            if (evid != 0)
            {
                var sorgu = evmanager.Get(x => x.evID == evid);
                textBox1.Text = sorgu.il;
                textBox2.Text = sorgu.ilce;
                textBox3.Text = sorgu.brütm2;
                textBox4.Text = sorgu.netm2;
                comboBox1.Text = sorgu.odasayisi;
                textBox5.Text = sorgu.binayas;
                textBox6.Text = sorgu.bulundugukat;
                textBox7.Text = sorgu.binadakitoplamkat;
                comboBox2.Text = sorgu.isitma;
                textBox8.Text = sorgu.banyosayisi.ToString();
                textBox9.Text = sorgu.Aidat.ToString();
                comboBox3.Text = sorgu.balkondurum.ToString();
                comboBox4.Text = sorgu.esyadurum.ToString();
                comboBox5.Text = sorgu.siteicidurum.ToString();
                comboBox6.Text = sorgu.krediyeuygunlukdurum.ToString();
                comboBox7.Text = sorgu.tapucesidi.ToString();
                comboBox8.Text = sorgu.takasdurum.ToString();
                comboBox9.Text = sorgu.satilikdurum.ToString();

                textBox11.Text = fotourl;

                var urlSorgu = fotomng.Get(x=>x.evID== evid);
                if (urlSorgu != null)
                {
                    textBox11.Text = urlSorgu.url;
                    pictureBox1.ImageLocation = urlSorgu.url;
                }else
                {
                    MessageBox.Show("Fotoğraf Bulunamadı.");
                }
                var basliksorgu = ILAN.Get(x => x.evID == evid);
                textBox10.Text = basliksorgu.Baslik;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sorgu = evmanager.Get(x => x.evID == evid);
            var sorgu2 = evFotoManager.Get(x=>x.evID==sorgu.evID);
            var sorgu3 = ilanmanager.Get(x=>x.evID == sorgu.evID);
            evFotoManager.Delete(sorgu2);
            evmanager.Delete(sorgu);
            ilanmanager.Delete(sorgu3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriIlanYonetim ilanyonform = new MusteriIlanYonetim(musteriid);
            ilanyonform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ev2 = evmanager.Get(x => x.evID == evid);
            ev2.il = textBox1.Text;
            ev2.ilce = textBox2.Text;
            ev2.brütm2 = textBox3.Text;
            ev2.netm2 = textBox4.Text;
            ev2.odasayisi = comboBox1.Text;
            ev2.binayas = textBox5.Text;
            ev2.bulundugukat = textBox6.Text;
            ev2.binadakitoplamkat = textBox7.Text;
            ev2.isitma = comboBox2.Text;
            ev2.banyosayisi = int.Parse(textBox8.Text);
            ev2.Aidat = int.Parse(textBox9.Text);
            ev2.balkondurum = comboBox3.Text == "Var" ? true : false;
            ev2.esyadurum = comboBox4.Text == "Evet" ? true : false; ;
            ev2.siteicidurum = comboBox5.Text == "Evet" ? true : false;
            ev2.krediyeuygunlukdurum = comboBox6.Text == "Evet" ? true : false;
            ev2.tapucesidi = true;
            ev2.takasdurum = comboBox8.Text == "Olur" ? true : false;
            ev2.satilikdurum = comboBox9.Text == "Satılık" ? true : false;
            evmanager.Update(ev2);
            MessageBox.Show("Ev Bilgisi Güncelleme Başarılı");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IlanManager mngilan = new IlanManager();

            var ilan2 = mngilan.Get(x=>x.evID == evid);
            ilan2.Baslik = textBox10.Text;
            ilanmanager.Update(ilan2);
            MessageBox.Show("Başlık Güncelleme Başarılı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EvFotoGuncellemeForm fotoguncForm = new EvFotoGuncellemeForm(evid, musteriid);
            fotoguncForm.Show();
            this.Hide();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox11.Text;
        }
    }
}
