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
    public partial class FormMemebership : Form
    {
        public FormMemebership()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        private void CLoseN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string CampusID = TxtSearchID.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LMember where CampusId = '" + CampusID + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridMember.DataSource = ds.Tables[0];
            PanelEdit.Visible = true;
        }

        Int64 Landline;
        Int64 Phoneno;
        private void GridMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && GridMember.Rows[e.RowIndex].Cells["CampusId"].Value != null)
                {
                    string campusId = GridMember.Rows[e.RowIndex].Cells["CampusId"].Value.ToString();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM LMember WHERE CampusId = @CampusId";
                    cmd.Parameters.AddWithValue("@CampusId", campusId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];

                        TxtcampusId.Text = row["CampusId"].ToString();
                        TxtNIC.Text = row["NIC"].ToString();
                        Txtfirst.Text = row["FirstName"].ToString();
                        TxtLast.Text = row["Lastname"].ToString();
                        TxtLand.Text = row["land"].ToString();
                        TxtPhone.Text = row["phone"].ToString();
                        Txtaddr.Text = row["mAddress"].ToString();

                        PanelEdit.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnRef_Click(object sender, EventArgs e)
        {
            TxtSearchID.Clear();
            PanelEdit.Visible = false;
        }


        private void FormMemebership_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LMember ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridMember.DataSource = ds.Tables[0];
            PanelEdit.Visible = false;
        }

        private void Btnupdt_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Data is going to be updated.Confirm?", "sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {                
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE LMember SET CampusId = @CampusId, FirstName = @FirstName, Lastname = @Lastname, NIC = @NIC, land = @land, mAddress = @mAddress, phone = @phone WHERE CampusId = @CampusId";
                    cmd.Parameters.AddWithValue("@CampusId", TxtcampusId.Text);
                    cmd.Parameters.AddWithValue("@FirstName", Txtfirst.Text);
                    cmd.Parameters.AddWithValue("@Lastname", TxtLast.Text);
                    cmd.Parameters.AddWithValue("@NIC", TxtNIC.Text);
                    cmd.Parameters.AddWithValue("@land", TxtLand.Text);
                    cmd.Parameters.AddWithValue("@mAddress", Txtaddr.Text);
                    cmd.Parameters.AddWithValue("@phone", TxtPhone.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlCommand refreshCmd = new SqlCommand("SELECT * FROM LMember", con);
                    SqlDataAdapter da = new SqlDataAdapter(refreshCmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        GridMember.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchID_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearchID.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM LMember where CampusId Like '" + TxtcampusId.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridMember.DataSource = ds.Tables[0];
            }
        }
    }
}
