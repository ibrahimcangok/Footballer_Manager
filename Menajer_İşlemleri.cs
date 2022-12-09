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
    public partial class Menajer_İşlemleri : Form
    {
        public Menajer_İşlemleri()
        {
            InitializeComponent();
        }

        private void kydt_Click(object sender, EventArgs e)
        {
            try
            {
                Menajer KayitEkle = new Menajer();
                KayitEkle.KayitEkle(m_adı.Text, m_soyadı.Text, long.Parse(m_telefon.Text), long.Parse(m_fiyat.Text), long.Parse(m_yas.Text), m_ulke.Text);
                Menajer KayitlariGoster = new Menajer();
                KayitlariGoster.KayitlariGoster(dataGridView1, "Select * FROM menajer");
                m_adı.Clear();
                m_soyadı.Clear();
                m_telefon.Clear();
                m_fiyat.Clear();
                m_yas.Clear();
                m_ulke.Clear();
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
                Menajer VeriSil = new Menajer();
                VeriSil.VeriSil(dataGridView1);
                Menajer KayitlariGoster = new Menajer();
                KayitlariGoster.KayitlariGoster(dataGridView1, "Select * FROM menajer");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem !", "Hata Mesajı");
            }
            m_adı.Clear();
            m_soyadı.Clear();
            m_telefon.Clear();
            m_fiyat.Clear();
            m_yas.Clear();
            m_ulke.Clear();      
        }

        private void Menajer_İşlemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Magenta;
            Menajer KayitlariGoster = new Menajer();
            KayitlariGoster.KayitlariGoster(dataGridView1, "Select * FROM menajer");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_adı.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            m_soyadı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            m_telefon.Text = Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            m_fiyat.Text = Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            m_yas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            m_ulke.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void ana_sayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa s = new AnaSayfa();
            s.Show();
            this.Hide();
        }
    }
}
