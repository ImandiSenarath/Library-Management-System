using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Library_Management_System
{
    public partial class New_book : Form
    {
        public New_book()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        //minimize button
        private void CLoseN_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //back button
        private void BackN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //minimize button
        private void MinimizeN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //addnew book button
        private void Btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CreateBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Author", TxtauthA.Text);
            cmd.Parameters.AddWithValue("@Title", TxtTiittleA.Text);
            cmd.Parameters.AddWithValue("@Publisher", TxtpubA.Text);
            cmd.Parameters.AddWithValue("@Genre", TxtGenreA.Text);
            cmd.Parameters.AddWithValue("@Permission", TxtpwerA.Text);
            cmd.Parameters.AddWithValue("@Shelf", TxtshelfA.Text);
            int numberOfCopies;
            if (!string.IsNullOrWhiteSpace(TxtnoA.Text) && int.TryParse(TxtnoA.Text, out numberOfCopies))
            {
                cmd.Parameters.AddWithValue("@NumberOfCopies", numberOfCopies);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Lblmsg.Text = "Failed to create book record";
                }
                else
                {
                    Lblmsg.Text = "Book record created successfully.";
                    TxtauthA.Clear();
                    TxtGenreA.Clear();
                    TxtnoA.Clear();
                    TxtpubA.Clear();
                    TxtpwerA.Clear();
                    TxtshelfA.Clear();
                    TxtTiittleA.Clear();
                }
            }
            con.Close();
        }
    }
}