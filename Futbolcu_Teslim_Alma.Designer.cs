namespace Örnek_Proje
{
    partial class Futbolcu_Teslim_Alma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Futbolcu_Teslim_Alma));
            this.futbolcubox = new System.Windows.Forms.ComboBox();
            this.teslim_al = new System.Windows.Forms.Button();
            this.f_lbl = new System.Windows.Forms.Label();
            this.ana_sayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futbolcubox
            // 
            this.futbolcubox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.futbolcubox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futbolcubox.FormattingEnabled = true;
            this.futbolcubox.Location = new System.Drawing.Point(183, 72);
            this.futbolcubox.Name = "futbolcubox";
            this.futbolcubox.Size = new System.Drawing.Size(113, 21);
            this.futbolcubox.TabIndex = 1;
            // 
            // teslim_al
            // 
            this.teslim_al.BackColor = System.Drawing.Color.LightSeaGreen;
            this.teslim_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teslim_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslim_al.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teslim_al.Location = new System.Drawing.Point(95, 97);
            this.teslim_al.Name = "teslim_al";
            this.teslim_al.Size = new System.Drawing.Size(115, 51);
            this.teslim_al.TabIndex = 2;
            this.teslim_al.Text = "Teslim Al";
            this.teslim_al.UseVisualStyleBackColor = false;
            this.teslim_al.Click += new System.EventHandler(this.teslim_al_Click);
            // 
            // f_lbl
            // 
            this.f_lbl.AutoSize = true;
            this.f_lbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.f_lbl.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_lbl.ForeColor = System.Drawing.Color.White;
            this.f_lbl.Location = new System.Drawing.Point(4, 71);
            this.f_lbl.Name = "f_lbl";
            this.f_lbl.Size = new System.Drawing.Size(178, 23);
            this.f_lbl.TabIndex = 4;
            this.f_lbl.Text = "Futbolcu Bilgisi :";
            // 
            // ana_sayfa
            // 
            this.ana_sayfa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ana_sayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ana_sayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ana_sayfa.Location = new System.Drawing.Point(3, 3);
            this.ana_sayfa.Name = "ana_sayfa";
            this.ana_sayfa.Size = new System.Drawing.Size(101, 26);
            this.ana_sayfa.TabIndex = 31;
            this.ana_sayfa.Text = "ANA SAYFA";
            this.ana_sayfa.UseVisualStyleBackColor = false;
            this.ana_sayfa.Click += new System.EventHandler(this.ana_sayfa_Click);
            // 
            // Futbolcu_Teslim_Alma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 236);
            this.Controls.Add(this.ana_sayfa);
            this.Controls.Add(this.f_lbl);
            this.Controls.Add(this.teslim_al);
            this.Controls.Add(this.futbolcubox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Futbolcu_Teslim_Alma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Futbolcu_Teslim_Alma";
            this.Load += new System.EventHandler(this.Futbolcu_Teslim_Alma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox futbolcubox;
        private System.Windows.Forms.Button teslim_al;
        private System.Windows.Forms.Label f_lbl;
        private System.Windows.Forms.Button ana_sayfa;
    }
}