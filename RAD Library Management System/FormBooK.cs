using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Library_Management_System
{
    public partial class FormBooK : Form
    {
        public FormBooK()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        private void BackN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CLoseN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = TxtNam.Text.Trim();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Book where Title = '" + searchTitle + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridBook.DataSource = ds.Tables[0];
            PanelEdit.Visible = true;

        }


        private void FormBooK_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Book ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridBook.DataSource = ds.Tables[0];
            PanelEdit.Visible = false;
        }

        Int64 ISBN;
        Int64 rowid;
        Int64 noofcopies;
        private void GridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ISBN = Int64.Parse(GridBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    noofcopies = Int64.Parse(GridBook.Rows[e.RowIndex].Cells[0].Value.ToString());

                    PanelEdit.Visible = true;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Book WHERE ISBN = @ISBN";
                    cmd.Parameters.AddWithValue("@ISBN", ISBN);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        TxtIsbn.Text = ds.Tables[0].Rows[0]["ISBN"].ToString();
                        TxtTitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                        TxtGenre.Text = ds.Tables[0].Rows[0]["Genre"].ToString();
                        TxtNocopiew.Text = ds.Tables[0].Rows[0]["NumberOfCopies"].ToString();
                        TxtPerMission.Text = ds.Tables[0].Rows[0]["Permission"].ToString();
                        TxtShwlf.Text = ds.Tables[0].Rows[0]["Shelf"].ToString();
                        TxtPublisher.Text = ds.Tables[0].Rows[0]["Publisher"].ToString();
                        TxtAuthor.Text = ds.Tables[0].Rows[0]["Author"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void TxtNam_TextChanged(object sender, EventArgs e)
        {
            if (TxtNam.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Book where Title Like '" + TxtTitle.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridBook.DataSource = ds.Tables[0];

            }
        }

        private void BtnRef_Click(object sender, EventArgs e)
        {
            TxtNam.Clear();
            PanelEdit.Visible = false;
        }

        private void Btnupdt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data is going to be updated.Confirm?", "sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Int64 isbn = Int64.Parse(TxtIsbn.Text);
                    noofcopies = Int64.Parse(Txtcono.Text);
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE Book SET Author = @Author, Title = @Title, Publisher = @Publisher, Genre = @Genre, Permission = @Permission, Shelf = @Shelf, NumberOfCopies = @NumberOfCopies WHERE ISBN = @ISBN";
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Author", TxtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Title", TxtTitle.Text);
                    cmd.Parameters.AddWithValue("@Publisher", TxtPublisher.Text);
                    cmd.Parameters.AddWithValue("@Genre", TxtGenre.Text);
                    cmd.Parameters.AddWithValue("@Permission", TxtPerMission.Text);
                    cmd.Parameters.AddWithValue("@Shelf", TxtShwlf.Text);
                    cmd.Parameters.AddWithValue("@NumberOfCopies", noofcopies);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlCommand refreshCmd = new SqlCommand("SELECT * FROM Book", con);
                    SqlDataAdapter da = new SqlDataAdapter(refreshCmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        GridBook.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data is going to be updated.Confirm?", "sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "delete from Book  where Isbn = '" + ISBN + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
            }
        }
    }
}
