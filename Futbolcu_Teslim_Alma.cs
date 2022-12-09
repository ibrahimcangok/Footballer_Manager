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
    public partial class Futbolcu_Teslim_Alma : Form
    {
        public Futbolcu_Teslim_Alma()
        {
            InitializeComponent();
        }

        private void Futbolcu_Teslim_Alma_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= Database1.accdb");
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "Select F_Ad from futbolcu Where Durum_F='Kiralandı'";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                futbolcubox.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }

        private void teslim_al_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= Database1.accdb");
                OleDbCommand gunce = new OleDbCommand();
                gunce.Connection = baglanti;
                baglanti.Open();
                gunce.CommandText = "Update futbolcu set Durum_F='" + "Uygun" + "' where F_Ad='" + futbolcubox.Text + "'";
                gunce.ExecuteNonQuery();
                futbolcubox.Text = "";
                MessageBox.Show("Futbolcu Teslim Alındı");
                OleDbDataReader oku = gunce.ExecuteReader();
                while (oku.Read())
                {
                    futbolcubox.Items.Add(oku[0].ToString());
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
