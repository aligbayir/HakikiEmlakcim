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
    public partial class AnaSayfa : Form
    {
        public int evid;
        public string musteriid;

        public AnaSayfa()
        {
            InitializeComponent();

        }
        IlanManager ilanmng = new IlanManager();

        public void Listele()
        {
            var sorgu = ilanmng.GetAll().Select(x => new { x.musteriID, x.evID, x.Baslik, x.tbl_ev.il, x.tbl_ev.ilce, x.tbl_ev.satilikdurum, x.tbl_ev.odasayisi });

            dataGridView1.DataSource = sorgu.ToList();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriGiris mustgirisform = new MusteriGiris();
            mustgirisform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriKayitForm musteriKayitForm = new MusteriKayitForm();
            musteriKayitForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string mid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string id = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            IlanDetailForm form = new IlanDetailForm(id, mid);
            form.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //EvManager evManager = new EvManager();
            //var sorgu = evManager.GetAll().Where(x => x.il == textBox1.Text.Trim());
            //var sorgu2 = ilanmng.GetAll().Where(x => x.tbl_ev.il == textBox1.Text.Trim()).Select(x => new { x.musteriID, x.evID, x.Baslik, x.tbl_ev.il, x.tbl_ev.ilce, x.tbl_ev.satilikdurum, x.tbl_ev.odasayisi });
            //dataGridView1.DataSource = sorgu2;

            if (textBox1.Text != null)
            {
                IlanManager imng = new IlanManager();
                var sorgu = imng.GetAll().Where(x => x.tbl_ev.il == textBox1.Text).Select(x => new { x.musteriID, x.evID, x.Baslik, x.tbl_ev.il, x.tbl_ev.ilce, x.tbl_ev.satilikdurum, x.tbl_ev.odasayisi }).ToList();
                dataGridView1.DataSource = sorgu;
                textBox1.Text = "";
            }
            //else if (textBox1.Text == null) 
            //{
            //    IlanManager ilmng = new IlanManager();
            //    var sorgu2 = ilmng.GetAll().Select(x => new { x.musteriID, x.evID, x.Baslik, x.tbl_ev.il, x.tbl_ev.ilce, x.tbl_ev.satilikdurum, x.tbl_ev.odasayisi });

            //    dataGridView1.DataSource = sorgu2.ToList();
            //}
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            IlanManager ilmng = new IlanManager();
            var sorgu2 = ilmng.GetAll().Select(x => new { x.musteriID, x.evID, x.Baslik, x.tbl_ev.il, x.tbl_ev.ilce, x.tbl_ev.satilikdurum, x.tbl_ev.odasayisi });

            dataGridView1.DataSource = sorgu2.ToList();
        }
    }
}
