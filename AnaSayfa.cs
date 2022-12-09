using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Örnek_Proje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void futbolcu_islemleri_Click(object sender, EventArgs e)
        {
            Futbolcu_İşlemleri s = new Futbolcu_İşlemleri();
            s.Show();
            this.Hide();
        }

        private void menajer_islemleri_Click(object sender, EventArgs e)
        {
            Menajer_İşlemleri s = new Menajer_İşlemleri();
            s.Show();
            this.Hide();
        }

        private void futbolcu_menajer_kiralama_Click(object sender, EventArgs e)
        {
            Futbolcu_Menajer_Kiralama s = new Futbolcu_Menajer_Kiralama();
            s.Show();
            this.Hide();
        }

        private void futbolcu_teslim_alma_Click(object sender, EventArgs e)
        {
            Futbolcu_Teslim_Alma s = new Futbolcu_Teslim_Alma();
            s.Show();
            this.Hide();
        }

        private void menajer_teslim_alma_Click(object sender, EventArgs e)
        {
            Menajer_Teslim_Alma s = new Menajer_Teslim_Alma();
            s.Show();
            this.Hide();
        }
    }
}