using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            newBook.bookId = txtbookId.Text;
            newBook.bookName = txtBookName.Text;
            newBook.bookAurthor = txtBookAurthor.Text;
            newBook.bookSummery = txtBookSummery.Text;
            newBook.bookStatus = txtBookStatus.Text;

            if (string.IsNullOrEmpty(txtbookId.Text) || string.IsNullOrEmpty(txtBookName.Text) || string.IsNullOrEmpty(txtBookAurthor.Text) || string.IsNullOrEmpty(txtBookSummery.Text) || string.IsNullOrEmpty(txtBookStatus.Text))
                return;

            ListViewItem item = new ListViewItem(txtbookId.Text);
            item.SubItems.Add(txtBookName.Text);
            item.SubItems.Add(txtBookAurthor.Text);
            item.SubItems.Add(txtBookSummery.Text);
            item.SubItems.Add(txtBookStatus.Text);
            ListViewBook.Items.Add(item);
            txtBookName.Clear();
            txtbookId.Clear();
            txtBookAurthor.Clear();
            txtBookSummery.Clear();
            txtBookStatus.Clear();
            txtbookId.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ListViewBook.Items.Count > 0)
                ListViewBook.Items.Remove(ListViewBook.SelectedItems[0]);
        }

        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtbookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtBookAurthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
