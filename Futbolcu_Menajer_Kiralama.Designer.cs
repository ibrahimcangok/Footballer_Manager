namespace Örnek_Proje
{
    partial class Futbolcu_Menajer_Kiralama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Futbolcu_Menajer_Kiralama));
            this.futbolcubox = new System.Windows.Forms.ComboBox();
            this.menajerbox = new System.Windows.Forms.ComboBox();
            this.alış = new System.Windows.Forms.DateTimePicker();
            this.veriş = new System.Windows.Forms.DateTimePicker();
            this.lbl_ftbl = new System.Windows.Forms.Label();
            this.lbl_mnjr = new System.Windows.Forms.Label();
            this.lbl_alış = new System.Windows.Forms.Label();
            this.lbl_veriş = new System.Windows.Forms.Label();
            this.kıralama = new System.Windows.Forms.Button();
            this.ana_sayfa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // futbolcubox
            // 
            this.futbolcubox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.futbolcubox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futbolcubox.ForeColor = System.Drawing.Color.White;
            this.futbolcubox.FormattingEnabled = true;
            this.futbolcubox.Location = new System.Drawing.Point(249, 91);
            this.futbolcubox.Name = "futbolcubox";
            this.futbolcubox.Size = new System.Drawing.Size(121, 21);
            this.futbolcubox.TabIndex = 1;
            // 
            // menajerbox
            // 
            this.menajerbox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menajerbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menajerbox.ForeColor = System.Drawing.Color.White;
            this.menajerbox.FormattingEnabled = true;
            this.menajerbox.Location = new System.Drawing.Point(245, 64);
            this.menajerbox.Name = "menajerbox";
            this.menajerbox.Size = new System.Drawing.Size(121, 21);
            this.menajerbox.TabIndex = 0;
            // 
            // alış
            // 
            this.alış.Location = new System.Drawing.Point(202, 120);
            this.alış.Name = "alış";
            this.alış.Size = new System.Drawing.Size(200, 20);
            this.alış.TabIndex = 2;
            // 
            // veriş
            // 
            this.veriş.Location = new System.Drawing.Point(213, 147);
            this.veriş.Name = "veriş";
            this.veriş.Size = new System.Drawing.Size(200, 20);
            this.veriş.TabIndex = 3;
            // 
            // lbl_ftbl
            // 
            this.lbl_ftbl.AutoSize = true;
            this.lbl_ftbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_ftbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ftbl.ForeColor = System.Drawing.Color.White;
            this.lbl_ftbl.Location = new System.Drawing.Point(71, 91);
            this.lbl_ftbl.Name = "lbl_ftbl";
            this.lbl_ftbl.Size = new System.Drawing.Size(182, 25);
            this.lbl_ftbl.TabIndex = 6;
            this.lbl_ftbl.Text = "Futbolcu Bilgisi :";
            // 
            // lbl_mnjr
            // 
            this.lbl_mnjr.AutoSize = true;
            this.lbl_mnjr.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_mnjr.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mnjr.ForeColor = System.Drawing.Color.White;
            this.lbl_mnjr.Location = new System.Drawing.Point(71, 64);
            this.lbl_mnjr.Name = "lbl_mnjr";
            this.lbl_mnjr.Size = new System.Drawing.Size(177, 25);
            this.lbl_mnjr.TabIndex = 7;
            this.lbl_mnjr.Text = "Menajer Bilgisi :";
            // 
            // lbl_alış
            // 
            this.lbl_alış.AutoSize = true;
            this.lbl_alış.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_alış.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alış.ForeColor = System.Drawing.Color.White;
            this.lbl_alış.Location = new System.Drawing.Point(71, 118);
            this.lbl_alış.Name = "lbl_alış";
            this.lbl_alış.Size = new System.Drawing.Size(128, 25);
            this.lbl_alış.TabIndex = 8;
            this.lbl_alış.Text = "Alış Tarihi :";
            // 
            // lbl_veriş
            // 
            this.lbl_veriş.AutoSize = true;
            this.lbl_veriş.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_veriş.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veriş.ForeColor = System.Drawing.Color.White;
            this.lbl_veriş.Location = new System.Drawing.Point(71, 144);
            this.lbl_veriş.Name = "lbl_veriş";
            this.lbl_veriş.Size = new System.Drawing.Size(143, 25);
            this.lbl_veriş.TabIndex = 9;
            this.lbl_veriş.Text = "Veriş Tarihi :";
            // 
            // kıralama
            // 
            this.kıralama.BackColor = System.Drawing.Color.LightSeaGreen;
            this.kıralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kıralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kıralama.ForeColor = System.Drawing.Color.White;
            this.kıralama.Location = new System.Drawing.Point(183, 170);
            this.kıralama.Name = "kıralama";
            this.kıralama.Size = new System.Drawing.Size(121, 37);
            this.kıralama.TabIndex = 13;
            this.kıralama.Text = "Kirala";
            this.kıralama.UseVisualStyleBackColor = false;
            this.kıralama.Click += new System.EventHandler(this.kıralama_Click);
            // 
            // ana_sayfa
            // 
            this.ana_sayfa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ana_sayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ana_sayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ana_sayfa.Location = new System.Drawing.Point(3, 2);
            this.ana_sayfa.Name = "ana_sayfa";
            this.ana_sayfa.Size = new System.Drawing.Size(101, 26);
            this.ana_sayfa.TabIndex = 31;
            this.ana_sayfa.Text = "ANA SAYFA";
            this.ana_sayfa.UseVisualStyleBackColor = false;
            this.ana_sayfa.Click += new System.EventHandler(this.ana_sayfa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // Futbolcu_Menajer_Kiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ana_sayfa);
            this.Controls.Add(this.kıralama);
            this.Controls.Add(this.lbl_veriş);
            this.Controls.Add(this.lbl_alış);
            this.Controls.Add(this.lbl_mnjr);
            this.Controls.Add(this.lbl_ftbl);
            this.Controls.Add(this.veriş);
            this.Controls.Add(this.alış);
            this.Controls.Add(this.menajerbox);
            this.Controls.Add(this.futbolcubox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Futbolcu_Menajer_Kiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Futbolcu_Menajer_Kiralama";
            this.Load += new System.EventHandler(this.Futbolcu_Menajer_Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox futbolcubox;
        private System.Windows.Forms.ComboBox menajerbox;
        private System.Windows.Forms.DateTimePicker alış;
        private System.Windows.Forms.DateTimePicker veriş;
        private System.Windows.Forms.Label lbl_ftbl;
        private System.Windows.Forms.Label lbl_mnjr;
        private System.Windows.Forms.Label lbl_alış;
        private System.Windows.Forms.Label lbl_veriş;
        private System.Windows.Forms.Button kıralama;
        private System.Windows.Forms.Button ana_sayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}