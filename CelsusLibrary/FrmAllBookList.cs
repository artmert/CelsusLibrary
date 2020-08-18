using CelsusLibrary.Data;
using CelsusLibrary.Utility;
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
    public partial class FrmAllBookList : Form
    {
        public FrmAllBookList()
        {
            InitializeComponent();
        }
        AddBook sort = new AddBook();
        private void FrmAllBookList_Load(object sender, EventArgs e)
        {
            grdAllBooksList.DataSource = sort.Filter(null,true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grdAllBooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKitapAdi(object sender, EventArgs e)
        {

        }
    }
}
