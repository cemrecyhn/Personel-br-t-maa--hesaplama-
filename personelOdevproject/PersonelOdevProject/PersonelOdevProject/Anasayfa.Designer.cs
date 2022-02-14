
namespace PersonelOdevProject
{
    partial class Anasayfa
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
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maaşBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araBulMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgileriGösterMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(12, 104);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(221, 26);
            this.txtPersonelId.TabIndex = 0;
            this.txtPersonelId.TextChanged += new System.EventHandler(this.txtPersonelId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Sayısını Belirle :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maaşBilgileriToolStripMenuItem,
            this.araBulMenüToolStripMenuItem,
            this.bilgileriGösterMenüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maaşBilgileriToolStripMenuItem
            // 
            this.maaşBilgileriToolStripMenuItem.Enabled = false;
            this.maaşBilgileriToolStripMenuItem.Name = "maaşBilgileriToolStripMenuItem";
            this.maaşBilgileriToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.maaşBilgileriToolStripMenuItem.Text = "Maaş Bilgileri Menü ";
            this.maaşBilgileriToolStripMenuItem.Click += new System.EventHandler(this.maaşBilgileriToolStripMenuItem_Click);
            // 
            // araBulMenüToolStripMenuItem
            // 
            this.araBulMenüToolStripMenuItem.Enabled = false;
            this.araBulMenüToolStripMenuItem.Name = "araBulMenüToolStripMenuItem";
            this.araBulMenüToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.araBulMenüToolStripMenuItem.Text = " Ara/Bul Menü";
            this.araBulMenüToolStripMenuItem.Click += new System.EventHandler(this.araBulMenüToolStripMenuItem_Click);
            // 
            // bilgileriGösterMenüToolStripMenuItem
            // 
            this.bilgileriGösterMenüToolStripMenuItem.Enabled = false;
            this.bilgileriGösterMenüToolStripMenuItem.Name = "bilgileriGösterMenüToolStripMenuItem";
            this.bilgileriGösterMenüToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.bilgileriGösterMenüToolStripMenuItem.Text = "Bilgileri Göster Menü";
            this.bilgileriGösterMenüToolStripMenuItem.Click += new System.EventHandler(this.bilgileriGösterMenüToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelId);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maaşBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araBulMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgileriGösterMenüToolStripMenuItem;
    }
}