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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteApplicant(int.Parse(txtDelete.Text));
        }

        private void btnExts_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
