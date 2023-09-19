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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook frm1 = new frmBook();
            frm1.Show();
            
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            frm.Show();
            
        }
    }
}
