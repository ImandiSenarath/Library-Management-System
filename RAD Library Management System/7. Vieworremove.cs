using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RAD_Library_Management_System
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            PopulateCisbn();
            PopulateCtittle();
            PopulateCauth();
            PopulateCpub();
            PopulateLblgenre();
            PopulatepermC();
            PopulateCshelf();
            PopulateCno();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        private void PopulateCno()
        {
            
        }

        private void PopulatepermC()
        {
          
        }

        private void PopulateCshelf()
        {
            
        }

        private void PopulateLblgenre()
        {
            throw new NotImplementedException();
        }

        private void PopulateCpub()
        {



        }

        private void PopulateCisbn()
        {

        }

        private void PopulateCtittle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Tittle FROM Book", con);  //Selecting the all the tittles in the database>book table
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Ctittle.Items.Add(rd["Tittle"].ToString());
            }
            rd.Close();
            con.Close();
        }

        private void PopulateCauth()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Author FROM Book", con);  //Selecting the all the authors in the database>book tabke
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Cauth.Items.Add(rd["Author"].ToString());
            }
            rd.Close();
            con.Close();
        }

        private void Btnview_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}