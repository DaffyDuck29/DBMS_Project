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

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class Loginwindow : Form
    {
        

        public Loginwindow()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";
            con.Open();
            string UserName = tb_Username.Text;
            string Password = tb_password.Text;
            SqlCommand cmd = new SqlCommand("select UserName,Password from Reg where UserName='" + tb_Username.Text + "'and Password='" + tb_password.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to AA Production");
                Mainpage m = new Mainpage();
                this.Hide();
                m.Show();

            }
            else
            {
                Wrong_password_alert wrong = new Wrong_password_alert();
                wrong.Show();
            }
            con.Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SetValueForText1= tb_Username.Text;
        }
    }




    
    }
