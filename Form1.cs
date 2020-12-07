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

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar 
                    ='*';
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/laxman_poudel7/");
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/coder.lax");
        }

        private void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/techylax");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
   SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username = '"+txtUsername.Text +"'and pass='"+txtPassword.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();

            }

            else
            { 
            MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


    }
}
