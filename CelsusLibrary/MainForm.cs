using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsusLibrary
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void KitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddBook b = new FrmAddBook();
            b.ShowDialog();

        }

        private void TümKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllBookList b = new FrmAllBookList();
            b.ShowDialog();
        }

        private void KitapDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void OkuyucularToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

    }
}
