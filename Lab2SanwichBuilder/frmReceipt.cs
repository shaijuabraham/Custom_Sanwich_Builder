using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2SanwichBuilder
{
    public partial class frmReceipt : Form
    {

        frmMain frmMain01 = new frmMain();
        
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain01.Show();
            this.Hide();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

        }

        
    }
}
