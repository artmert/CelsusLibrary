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
    public partial class FrmAddBook : Form
    {
        public FrmAddBook()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AddBook addNewBook = new AddBook();
            addNewBook.Add(BoxBookName.Text,BoxWriterName.Text,
                BoxWriterSurname.Text, BoxBookType.Text, BoxPrintDate.Text, BoxBookLang.Text,
                BoxEntryDate.Value, BoxBookBringer.Text);
        }

        private void BoxBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxEntrDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxEntryDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
