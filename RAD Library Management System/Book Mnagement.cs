using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Library_Management_System
{
    public partial class FrmBookmgt : Form
    {
        public FrmBookmgt()
        {
            InitializeComponent();
        }

        private void CLose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void Btnview_Click(object sender, EventArgs e)
        {
            this.Hide();

            VorD vor = new VorD();
            vor.ShowDialog();

            this.Show();

        }

        private void Btnrem_Click(object sender, EventArgs e)
        {

        }

        private void BtnupdtD_Click(object sender, EventArgs e)
        {

        }

        private void BackB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}