using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Library_Management_System
{
    public partial class FrmIssueReturn : Form
    {
        public FrmIssueReturn()
        {
            InitializeComponent();
            Load();
            LoadCisbn();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        //mehod load Isbn to the combo box
        private void LoadCisbn()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELEct Distinct ISBN FROM Book", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Cisbn.Items.Add(rd["ISBN"].ToString());
            }
            rd.Close();
            con.Close();
        }

        //grid Load
        private void Load()
        {
            try
            {
                con.Open();

                string Load = "SELECT R.IssueId , R.isbn , R.member, I.IssueDate , I.ReturnDate, R.duedate" +
                    " from Returnb R , Issue I Where R.IssueId=I.IssueId;";

                SqlDataAdapter ad = new SqlDataAdapter(Load, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Btnviw_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void CLoseV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeV_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
        }

        private void Btnret_Click(object sender, EventArgs e)
        {

        }

        private void BtnIssue_Click_1(object sender, EventArgs e)
        {

        }
    }
}