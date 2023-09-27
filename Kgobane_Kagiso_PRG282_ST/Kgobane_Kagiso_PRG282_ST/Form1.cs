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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            dgvApplicants.DataSource = handler.displayApplicants();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            handler.registerApplicant(int.Parse(txtAppID.Text), txtFName.Text, txtLName.Text, txtIDNum.Text, txtPhone.Text);
            MessageBox.Show("Successfully added applicant");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            handler.updateApplicant(int.Parse(txtAppID.Text), txtFName.Text, txtLName.Text, txtIDNum.Text, txtPhone.Text);
            MessageBox.Show("Successfully updated applicant");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete  frmDelete = new frmDelete();
            frmDelete.Show();
        }
    }
}
