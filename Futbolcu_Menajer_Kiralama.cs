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
    public partial class Futbolcu_Menajer_Kiralama : Form
    {
        public Futbolcu_Menajer_Kiralama()
        {
            InitializeComponent();
        }

        private void Futbolcu_Menajer_Kiralama_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= Database1.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbCommand komut3 = new OleDbCommand();
            komut.Connection = baglanti;
            komut3.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "Select F_Ad from futbolcu Where Durum_F='Uygun'";
            komut3.CommandText = "Select M_Ad from menajer Where Durum_M='Uygun'";
            OleDbDataReader oku = komut.ExecuteReader();
            OleDbDataReader oku3 = komut3.ExecuteReader();
            while (oku.Read())
            {
                futbolcubox.Items.Add(oku[0].ToString());
            }
            while (oku3.Read())
            {
                menajerbox.Items.Add(oku3[0].ToString());
            }
       
            baglanti.Close();
            Kiralama goster = new Kiralama();
            goster.KayitlariGoster(dataGridView1, "Select * FROM kiralama");
        }

        private void kıralama_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= Database1.accdb");
                OleDbCommand komut = new OleDbCommand();
                OleDbCommand gunce = new OleDbCommand();
                OleDbCommand gunce2 = new OleDbCommand();     
                komut.Connection = baglanti;
                gunce.Connection = baglanti;      
                gunce2.Connection = baglanti;
                baglanti.Open();
                komut.CommandText = "INSERT INTO kiralama(M_Ad,F_Ad,al,ver) VALUES('" + menajerbox.Text + "' , '" + futbolcubox.Text + "','" + Convert.ToDateTime(alış.Text) + "',' " + Convert.ToDateTime(veriş.Text) + "')";           
                gunce.CommandText = "Update futbolcu set Durum_F='" + "Kiralandı" + "' where F_Ad='" + futbolcubox.Text + "'";
                gunce2.CommandText = "Update menajer set Durum_M='" + "Kiralandı" + "' where M_Ad='" + menajerbox.Text + "'";
                komut.ExecuteNonQuery();
                gunce.ExecuteNonQuery();
                gunce2.ExecuteNonQuery();
                futbolcubox.Text = "";
                menajerbox.Text = "";
                MessageBox.Show("Futbolcu Ve Menajer Kiralandı");
                OleDbDataReader oku = gunce.ExecuteReader();
                OleDbDataReader oku2 = gunce2.ExecuteReader();
                while (oku.Read())
                {
                    futbolcubox.Items.Add(oku[0].ToString());
                }
                while (oku2.Read())
                {
                    menajerbox.Items.Add(oku2[0].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Boşa Basma!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        } 

        private void ana_sayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa s = new AnaSayfa();
            s.Show();
            this.Hide();
        }     
    }
}
        

