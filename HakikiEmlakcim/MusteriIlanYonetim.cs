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
    public partial class MusteriIlanYonetim : Form
    {
        
        public MusteriIlanYonetim()
        {
            InitializeComponent();
            
        }
        public int musteriid;
        public MusteriIlanYonetim(int id)
        {
            this.musteriid = id;
            InitializeComponent();
        }

        public int evID;
        IlanManager ilanmng = new IlanManager();
        MusteriManager musteriManager = new MusteriManager();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string evid = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            evID = int.Parse(evid);
            IlanEkle guncelle = new IlanEkle(musteriid, evID);
            guncelle.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void MusteriIlanYonetim_Load(object sender, EventArgs e)
        {
            var musteriIlanları = ilanmng.GetAll(x=>x.musteriID== musteriid).Select(x=> new {x.ilanID,x.musteriID,x.evID,x.Baslik}).ToList();
            var musteriAdi = musteriManager.Get(x => x.MusteriID == musteriid);
            dataGridView1.DataSource = musteriIlanları;
            label2.Text = musteriAdi.MusteriAd.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IlanEkle ekle = new IlanEkle(musteriid);
            ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AnaSayfa ansyfa = new AnaSayfa();
            ansyfa.Show();
            this.Hide();
        }
    }
}
