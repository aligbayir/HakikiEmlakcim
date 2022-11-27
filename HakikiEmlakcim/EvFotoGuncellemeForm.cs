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
    public partial class EvFotoGuncellemeForm : Form
    {
        public int evid { get; set; }
        public int musteriid { get; set; }

        EvFotoManager evFotoManager =  new EvFotoManager();
        public EvFotoGuncellemeForm(int evid, int musid)
        {
            InitializeComponent();
            this.evid = evid;
            this.musteriid = musid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var evfoto2 = evFotoManager.Get(x => x.evID == evid);
            evfoto2.url = textBox11.Text;
            var fotourl = evfoto2.url;
            evFotoManager.Update(evfoto2);
            MessageBox.Show("Fotoğraf Güncelleme Başarılı");
            MusteriIlanYonetim mustyonetim = new MusteriIlanYonetim(musteriid);
            mustyonetim.Show();
            this.Hide();
        }

        private void EvFotoGuncellemeForm_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
