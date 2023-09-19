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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            newBook.bookId = txtName.Text;
            newBook.bookName = txtLastName.Text;
            newBook.bookAurthor = txtCellPhone.Text;
            newBook.bookSummery = txtLibraryId.Text;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtCellPhone.Text) || string.IsNullOrEmpty(txtLibraryId.Text))
                return;
            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(txtLastName.Text);
            item.SubItems.Add(txtCellPhone.Text);
            item.SubItems.Add(txtLibraryId.Text);
            ListViewMember.Items.Add(item);
            txtLastName.Clear();
            txtName.Clear();
            txtCellPhone.Clear();
            txtLibraryId.Clear();
            txtLibraryId.Focus();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ListViewMember.Items.Count > 0)
                ListViewMember.Items.Remove(ListViewMember.SelectedItems[0]);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region txtName
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
           //Delete
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        #region txtLastName

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            //Delete
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        #region CellPhone
        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        
        private void txtCellPhone_Click(object sender, EventArgs e)
        {
         //delete 
        }
        private void txtCellPhone_TextChanged(object sender, EventArgs e)
        {
         //delete  
        }
        #endregion

        #region LibraryId
        private void txtLibraryId_KeyDown(object sender, KeyEventArgs e)
        {
            //Delete
        }

        private void txtLibraryId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #endregion

        
    }
}
