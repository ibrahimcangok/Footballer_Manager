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
    class Kiralama
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
        public void KayitlariGoster(DataGridView grid, string sorgu)
        {
            BaglantiAc();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sorgu, cnn);
            adapter.Fill(ds, "kiralama");
            grid.DataSource = ds.Tables[0];
            cnn.Close();
        }
    }
}
