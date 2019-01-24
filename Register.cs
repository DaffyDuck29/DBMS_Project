using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_back_Click(object sender, EventArgs e)
        {
            Firstpage firstpage = new Firstpage();
            this.Hide();
            firstpage.Show();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_done_register_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_password.Text != "")
            {

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Reg values('" + tb_Username.Text + "','" + tb_password.Text + "','" + tb_Cnic.Text + "','" + tb_Contact.Text + "')";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Account Registered Successfully");
                }
                catch
                {
                    MessageBox.Show("Please Enter Values in username and password");
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
