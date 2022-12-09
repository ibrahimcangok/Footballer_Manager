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
    class Futbolcu
    {
        OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= Database1.accdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        public void BaglantiAc()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception)
            {
                cnn.Close();
            }
        }
        public void KayitEkle(string ad, string soyad, long tel, long yas, long no, string klp, long fyt, string mevkı, string ulke)
        {
            BaglantiAc();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO futbolcu(F_Ad,Soyadı,Telefonu,Yaşı,Numarası,Klubü,Fiyatı,Mevkisi,Ülkesi,Durum_F) VALUES ('" + ad + "','" + soyad + "','" + tel + "','" + yas + "','" + no + "','" + klp + "','" + fyt + "','" + mevkı + "','" + ulke + "','" + "Uygun" + "')";
            cmd.Parameters.AddWithValue("F_Ad", ad);
            cmd.Parameters.AddWithValue("Soyadı", soyad);
            cmd.Parameters.AddWithValue("Telefonu", tel);
            cmd.Parameters.AddWithValue("Yaşı", yas);
            cmd.Parameters.AddWithValue("Numarası", no);
            cmd.Parameters.AddWithValue("Klubü", klp);
            cmd.Parameters.AddWithValue("Fiyatı", fyt);
            cmd.Parameters.AddWithValue("Mevkisi", mevkı);
            cmd.Parameters.AddWithValue("Ülkesi", ulke);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "Kayıt Ekleme");
            cnn.Close();
        }
        public void KayitlariGoster(DataGridView grid, string sorgu)
        {
            BaglantiAc();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sorgu, cnn);
            adapter.Fill(ds, "futbolcu");
            grid.DataSource = ds.Tables[0];
            cnn.Close();
        }
        public void VeriSil(DataGridView grid)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.CommandText = "delete from futbolcu where ID=" + grid.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem !");
            }
        }
    }
}

