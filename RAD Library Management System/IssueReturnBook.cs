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
    public partial class IssueReturnBook : Form
    {
        public IssueReturnBook()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Check if the student has already borrowed two books
                string checkQuery = "SELECT COUNT(*) FROM IssueReturn WHERE menroll = @menroll AND ReturnDate IS NULL";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@menroll", TxtEnr.Text);
                int bookCount = (int)checkCmd.ExecuteScalar();

                if (bookCount >= 2)
                {
                    MessageBox.Show("Student has already borrowed two books.");
                    return;
                }

                // Issue the book
                string issue = "INSERT INTO IssueReturn (menroll, mname, mcontact, bookname, issuedate) VALUES (@menroll, @mname, @mcontact, @bookname, @issuedate)";
                SqlCommand insertCmd = new SqlCommand(issue, con);
                insertCmd.Parameters.AddWithValue("@menroll", TxtEnr.Text);
                insertCmd.Parameters.AddWithValue("@mname", Txtname.Text);
                insertCmd.Parameters.AddWithValue("@mcontact", Txtcontact.Text);
                insertCmd.Parameters.AddWithValue("@bookname", comboBox1.Text);
                insertCmd.Parameters.AddWithValue("@issuedate", DateIssueB.Value.ToString("yyyy-MM-dd"));

                insertCmd.ExecuteNonQuery();

                // Update the book quantity
                string updateBookQty = "UPDATE Newbook SET bquant = bquant - 1 WHERE bname = @bookname";
                SqlCommand updateCmd = new SqlCommand(updateBookQty, con);
                updateCmd.Parameters.AddWithValue("@bookname", comboBox1.Text);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Book issued successfully!");

                // Reload available books
                LoadAvailableBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadAvailableBooks()
        {

            try
            {
                con.Open();
                string query = "SELECT Title FROM Book WHERE bquant > (SELECT COUNT(*) FROM ReturnIssue WHERE bookname = Newbook.bname AND retdate IS NULL)";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Title "].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading available books: " + ex.Message);
            }
        }

        private void BtnSearchI_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT FirstName, Lastname, contact FROM LMember WHERE CampusId  = @CampusId ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CampusId ", TxtEnr.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Txtname.Text = reader["FirstName "].ToString();
                        textBox1.Text = reader["Lastname "].ToString(); 
                        Txtcontact.Text = reader["phone "].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
               
    }
}
