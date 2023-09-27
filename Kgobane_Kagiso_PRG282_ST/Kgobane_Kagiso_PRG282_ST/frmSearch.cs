using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kgobane_Kagiso_PRG282_ST
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            dgvSearch.DataSource = handler.SearchApplicant(int.Parse(txtSearch.Text));
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
