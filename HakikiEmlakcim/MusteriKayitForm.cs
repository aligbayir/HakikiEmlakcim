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
using Entities;

namespace HakikiEmlakcim
{
    public partial class MusteriKayitForm : Form
    {
        public MusteriKayitForm()
        {
            InitializeComponent();
        }
        MusteriManager musterimng = new MusteriManager();
        tbl_musteri musteri = new tbl_musteri();
        //public void Listele()
        //{
        //   var sorgu = musterimng.GetAll().Select(x => new {
        //        x.MusteriID,    
        //        x.MusteriAd,
        //        x.MusteriSoyad,
        //        x.MusteriTel,
        //        x.MusteriTC
        //    });
        //    dataGridView1.DataSource = sorgu.ToList();
        //}
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri.MusteriAd = textBox1.Text;
            musteri.MusteriSoyad = textBox2.Text;
            musteri.MusteriTel = maskedTextBox1.Text;
            musteri.MusteriTC=maskedTextBox2.Text;
            musterimng.Add(musteri);
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
