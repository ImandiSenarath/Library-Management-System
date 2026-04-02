using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RAD_Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        SqlConnection con = new("Data Source=DESKTOP-3J22NMI\\SQLEXPRESS;Initial Catalog=LibraryA;Integrated Security=True");

        //Login Button
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new("User_Login", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@pwsd", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Frmhome home = new();
                home.Show();
                this.Hide();
            }
            else
            {
                Invalid.Text = "Invalid login. Please try again.";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();
        }

        //Minimize Button
        private void MinimizeL_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Close (Exit Application) Button
        private void CLoseL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clear Button
        private void Btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        //Checkbox to show password in astrics
        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Show.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

    }
}
