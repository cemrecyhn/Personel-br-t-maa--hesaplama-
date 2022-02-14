using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOdevProject
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
           // Registry.CurrentUser.SetValue("Maaş/Personel", "ID1959id2372");
        }

        private void txtPersonelId_TextChanged(object sender, EventArgs e)
        {
            maaşBilgileriToolStripMenuItem.Enabled = true;
        }

        private void btnMaasBilgileri_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAraBul_Click(object sender, EventArgs e)
        {
            
        }

        private void araBulMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AraBulForm araBulForm = new AraBulForm();
            araBulForm.ShowDialog();
        }

        private void maaşBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaasBilgiForm maasBilgiForm = new MaasBilgiForm();
            maasBilgiForm.personelSayisi = int.Parse(txtPersonelId.Text);
            maasBilgiForm.ShowDialog();
            araBulMenüToolStripMenuItem.Enabled = true;
            bilgileriGösterMenüToolStripMenuItem.Enabled = true;

        }

        private void bilgileriGösterMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BilgiForm frm = new BilgiForm();
            frm.ShowDialog();
        }
    }
}
