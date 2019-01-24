using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class Browse3 : UserControl
    {
        public Browse3()
        {
            InitializeComponent();
        }

        private void Browse3_Load(object sender, EventArgs e)
        {
            string source = @"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string sqlselectquery = "select top 5 * from sell   ";

            SqlCommand cmd = new SqlCommand(sqlselectquery, con);


            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_Username.Text = (dr["Title"].ToString());
                textBox1.Text = (dr["Price"].ToString());

                richTextBox1.Text = (dr["descrip"].ToString());

            }


            con.Close();
        }

        private void Browse3_MouseHover(object sender, EventArgs e)
        {
            string source = @"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string sqlselectquery = "select top 6 * from sell  ";

            SqlCommand cmd = new SqlCommand(sqlselectquery, con);


            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = (dr["Title"].ToString());
                textBox3.Text = (dr["Price"].ToString());

                richTextBox2.Text = (dr["descrip"].ToString());

            }


            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            add_Messages add = new add_Messages();
            add.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            add_Messages add = new add_Messages();
            add.Show();
        }
    }
}
