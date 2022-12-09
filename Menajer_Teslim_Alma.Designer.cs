namespace Örnek_Proje
{
    partial class Menajer_Teslim_Alma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menajer_Teslim_Alma));
            this.menajerbox = new System.Windows.Forms.ComboBox();
            this.teslim_al = new System.Windows.Forms.Button();
            this.m_tc = new System.Windows.Forms.Label();
            this.ana_sayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menajerbox
            // 
            this.menajerbox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menajerbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menajerbox.ForeColor = System.Drawing.SystemColors.Window;
            this.menajerbox.FormattingEnabled = true;
            this.menajerbox.Location = new System.Drawing.Point(181, 76);
            this.menajerbox.Name = "menajerbox";
            this.menajerbox.Size = new System.Drawing.Size(121, 21);
            this.menajerbox.TabIndex = 0;
            // 
            // teslim_al
            // 
            this.teslim_al.BackColor = System.Drawing.Color.LightSeaGreen;
            this.teslim_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teslim_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslim_al.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teslim_al.Location = new System.Drawing.Point(91, 102);
            this.teslim_al.Name = "teslim_al";
            this.teslim_al.Size = new System.Drawing.Size(121, 39);
            this.teslim_al.TabIndex = 1;
            this.teslim_al.Text = "Teslim Al";
            this.teslim_al.UseVisualStyleBackColor = false;
            this.teslim_al.Click += new System.EventHandler(this.teslim_al_Click);
            // 
            // m_tc
            // 
            this.m_tc.AutoSize = true;
            this.m_tc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.m_tc.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_tc.Location = new System.Drawing.Point(3, 74);
            this.m_tc.Name = "m_tc";
            this.m_tc.Size = new System.Drawing.Size(177, 25);
            this.m_tc.TabIndex = 3;
            this.m_tc.Text = "Menajer Bilgisi :";
            // 
            // ana_sayfa
            // 
            this.ana_sayfa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ana_sayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ana_sayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ana_sayfa.Location = new System.Drawing.Point(2, 3);
            this.ana_sayfa.Name = "ana_sayfa";
            this.ana_sayfa.Size = new System.Drawing.Size(101, 26);
            this.ana_sayfa.TabIndex = 31;
            this.ana_sayfa.Text = "ANA SAYFA";
            this.ana_sayfa.UseVisualStyleBackColor = false;
            this.ana_sayfa.Click += new System.EventHandler(this.ana_sayfa_Click);
            // 
            // Menajer_Teslim_Alma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 227);
            this.Controls.Add(this.ana_sayfa);
            this.Controls.Add(this.m_tc);
            this.Controls.Add(this.teslim_al);
            this.Controls.Add(this.menajerbox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menajer_Teslim_Alma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menajer_Teslim_Alma";
            this.Load += new System.EventHandler(this.Menajer_Teslim_Alma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menajerbox;
        private System.Windows.Forms.Button teslim_al;
        private System.Windows.Forms.Label m_tc;
        private System.Windows.Forms.Button ana_sayfa;
    }
}