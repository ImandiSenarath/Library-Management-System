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
    public partial class Frmhome : Form
    {
        public Frmhome()
        {
            InitializeComponent();
        }

        //Exit (Close) the application
        private void CLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimze 
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        //button to go to Add members form
        private void Btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_book Book = new New_book();
            Book.ShowDialog();
            this.Show();
        }


        //Button to go to Update , delete and view members form
        private void BtnDV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooK Book = new();
            Book.ShowDialog();
            this.Show();
        }


        //Button to visit to teh Member management form
        private void Btnmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMemebership member = new FormMemebership();
            member.ShowDialog();
            this.Show();
        }


        //button to visit to  the issue and return books form 
        private void BtnIss_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIssueReturn issue = new FrmIssueReturn();
            issue.ShowDialog();
            this.Show();
        }

        private void Frmhome_Load(object sender, EventArgs e)
        {

        }
    }
}