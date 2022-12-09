namespace Örnek_Proje
{
    partial class Menajer_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menajer_İşlemleri));
            this.m_fiyat = new System.Windows.Forms.TextBox();
            this.m_adı = new System.Windows.Forms.TextBox();
            this.m_soyadı = new System.Windows.Forms.TextBox();
            this.m_telefon = new System.Windows.Forms.TextBox();
            this.kydt = new System.Windows.Forms.Button();
            this.lblyas = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lbladı = new System.Windows.Forms.Label();
            this.lblsoyadı = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.sıl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.m_yas = new System.Windows.Forms.TextBox();
            this.m_ulke = new System.Windows.Forms.TextBox();
            this.lblulke = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ana_sayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_fiyat
            // 
            this.m_fiyat.Location = new System.Drawing.Point(71, 48);
            this.m_fiyat.Name = "m_fiyat";
            this.m_fiyat.Size = new System.Drawing.Size(100, 20);
            this.m_fiyat.TabIndex = 4;
            // 
            // m_adı
            // 
            this.m_adı.Location = new System.Drawing.Point(71, 22);
            this.m_adı.Name = "m_adı";
            this.m_adı.Size = new System.Drawing.Size(100, 20);
            this.m_adı.TabIndex = 1;
            // 
            // m_soyadı
            // 
            this.m_soyadı.Location = new System.Drawing.Point(254, 22);
            this.m_soyadı.Name = "m_soyadı";
            this.m_soyadı.Size = new System.Drawing.Size(100, 20);
            this.m_soyadı.TabIndex = 2;
            // 
            // m_telefon
            // 
            this.m_telefon.Location = new System.Drawing.Point(442, 25);
            this.m_telefon.Name = "m_telefon";
            this.m_telefon.Size = new System.Drawing.Size(100, 20);
            this.m_telefon.TabIndex = 3;
            // 
            // kydt
            // 
            this.kydt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.kydt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kydt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydt.ForeColor = System.Drawing.Color.White;
            this.kydt.Location = new System.Drawing.Point(548, 26);
            this.kydt.Name = "kydt";
            this.kydt.Size = new System.Drawing.Size(67, 46);
            this.kydt.TabIndex = 7;
            this.kydt.Text = "Kaydet";
            this.kydt.UseVisualStyleBackColor = false;
            this.kydt.Click += new System.EventHandler(this.kydt_Click);
            // 
            // lblyas
            // 
            this.lblyas.AutoSize = true;
            this.lblyas.BackColor = System.Drawing.Color.Transparent;
            this.lblyas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblyas.Location = new System.Drawing.Point(178, 48);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(53, 13);
            this.lblyas.TabIndex = 8;
            this.lblyas.Text = "M_Yaş :";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblfiyat.Location = new System.Drawing.Point(6, 48);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(62, 13);
            this.lblfiyat.TabIndex = 9;
            this.lblfiyat.Text = "M_Fiyatı :";
            // 
            // lbladı
            // 
            this.lbladı.AutoSize = true;
            this.lbladı.BackColor = System.Drawing.Color.Transparent;
            this.lbladı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladı.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbladı.Location = new System.Drawing.Point(6, 19);
            this.lbladı.Name = "lbladı";
            this.lbladı.Size = new System.Drawing.Size(50, 13);
            this.lbladı.TabIndex = 10;
            this.lbladı.Text = "M_Adı :";
            // 
            // lblsoyadı
            // 
            this.lblsoyadı.AutoSize = true;
            this.lblsoyadı.BackColor = System.Drawing.Color.Transparent;
            this.lblsoyadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyadı.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblsoyadı.Location = new System.Drawing.Point(178, 25);
            this.lblsoyadı.Name = "lblsoyadı";
            this.lblsoyadı.Size = new System.Drawing.Size(70, 13);
            this.lblsoyadı.TabIndex = 11;
            this.lblsoyadı.Text = "M_Soyadı :";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbltelefon.Location = new System.Drawing.Point(360, 25);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(82, 13);
            this.lbltelefon.TabIndex = 12;
            this.lbltelefon.Text = "M_Telefonu :";
            // 
            // sıl
            // 
            this.sıl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sıl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sıl.ForeColor = System.Drawing.Color.White;
            this.sıl.Location = new System.Drawing.Point(621, 26);
            this.sıl.Name = "sıl";
            this.sıl.Size = new System.Drawing.Size(67, 46);
            this.sıl.TabIndex = 19;
            this.sıl.Text = "Sil";
            this.sıl.UseVisualStyleBackColor = false;
            this.sıl.Click += new System.EventHandler(this.sıl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 155);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // m_yas
            // 
            this.m_yas.Location = new System.Drawing.Point(254, 48);
            this.m_yas.Name = "m_yas";
            this.m_yas.Size = new System.Drawing.Size(100, 20);
            this.m_yas.TabIndex = 5;
            // 
            // m_ulke
            // 
            this.m_ulke.Location = new System.Drawing.Point(442, 51);
            this.m_ulke.Name = "m_ulke";
            this.m_ulke.Size = new System.Drawing.Size(100, 20);
            this.m_ulke.TabIndex = 6;
            // 
            // lblulke
            // 
            this.lblulke.AutoSize = true;
            this.lblulke.BackColor = System.Drawing.Color.Transparent;
            this.lblulke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblulke.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblulke.Location = new System.Drawing.Point(360, 51);
            this.lblulke.Name = "lblulke";
            this.lblulke.Size = new System.Drawing.Size(67, 13);
            this.lblulke.TabIndex = 24;
            this.lblulke.Text = "M_Ülkesi :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.sıl);
            this.groupBox1.Controls.Add(this.m_adı);
            this.groupBox1.Controls.Add(this.m_fiyat);
            this.groupBox1.Controls.Add(this.lblulke);
            this.groupBox1.Controls.Add(this.m_soyadı);
            this.groupBox1.Controls.Add(this.kydt);
            this.groupBox1.Controls.Add(this.m_ulke);
            this.groupBox1.Controls.Add(this.m_telefon);
            this.groupBox1.Controls.Add(this.m_yas);
            this.groupBox1.Controls.Add(this.lblyas);
            this.groupBox1.Controls.Add(this.lblfiyat);
            this.groupBox1.Controls.Add(this.lbladı);
            this.groupBox1.Controls.Add(this.lblsoyadı);
            this.groupBox1.Controls.Add(this.lbltelefon);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 78);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYDET";
            // 
            // ana_sayfa
            // 
            this.ana_sayfa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ana_sayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ana_sayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ana_sayfa.Location = new System.Drawing.Point(12, 145);
            this.ana_sayfa.Name = "ana_sayfa";
            this.ana_sayfa.Size = new System.Drawing.Size(79, 46);
            this.ana_sayfa.TabIndex = 31;
            this.ana_sayfa.Text = "ANA SAYFA";
            this.ana_sayfa.UseVisualStyleBackColor = false;
            this.ana_sayfa.Click += new System.EventHandler(this.ana_sayfa_Click);
            // 
            // Menajer_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 363);
            this.Controls.Add(this.ana_sayfa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menajer_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menajer_İşlemleri";
            this.Load += new System.EventHandler(this.Menajer_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox m_fiyat;
        private System.Windows.Forms.TextBox m_adı;
        private System.Windows.Forms.TextBox m_soyadı;
        private System.Windows.Forms.TextBox m_telefon;
        private System.Windows.Forms.Button kydt;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lbladı;
        private System.Windows.Forms.Label lblsoyadı;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Button sıl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox m_yas;
        private System.Windows.Forms.TextBox m_ulke;
        private System.Windows.Forms.Label lblulke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ana_sayfa;
    }
}