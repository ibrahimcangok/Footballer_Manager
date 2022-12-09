using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Örnek_Proje
{
    public partial class Futbolcu_İşlemleri : Form
    {
        public Futbolcu_İşlemleri()
        {
            InitializeComponent();
        }    

        private void kydt_Click(object sender, EventArgs e)
        {
            try
            {
                Futbolcu KayitEkle = new Futbolcu();           
                KayitEkle.KayitEkle(ad.Text, soyad.Text, long.Parse(tel.Text), long.Parse(yas.Text), long.Parse(no.Text), klp.Text, long.Parse(fyt.Text), mevkı.Text, ulke.Text);
                Futbolcu KayitlariGoster = new Futbolcu();
                KayitlariGoster.KayitlariGoster(dataGridView1, "Select * FROM futbolcu");
                ad.Clear();
                soyad.Clear();
                tel.Clear();
                yas.Clear();
                no.Clear();
                klp.Clear();
                fyt.Clear();
                mevkı.Clear();
                ulke.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("", "Boşa Basma!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sıl_Click(object sender, EventArgs e)
        {
            try
            {
                Futbolcu VeriSil = new Futbolcu();              
                VeriSil.VeriSil(dataGridView1);             
                Futbolcu KayitlariGoster = new Futbolcu();             
                KayitlariGoster.KayitlariGoster(dataGridView1, "Select * FROM futbolcu");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem !", "Hata Mesajı");
            }
            ad.Clear();
            soyad.Clear();
            tel.Clear();
            yas.Clear();
            no.Clear();
            klp.Clear();
            fyt.Clear();
            mevkı.Clear();
            ulke.Clear();
        }

        private void Futbolcu_İşlemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Magenta;
            Futbolcu KayitlariGoster = new Futbolcu();
            KayitlariGoster.KayitlariGoster(dataGridView1, "Select * FROM futbolcu");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tel.Text = Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yas.Text = Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            no.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            klp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fyt.Text = Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mevkı.Text = Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ulke.Text = Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void ana_sayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa s = new AnaSayfa();
            s.Show();
            this.Hide();
        }
    }
}
