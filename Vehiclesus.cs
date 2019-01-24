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
using System.Data.Sql;
namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class Vehiclesus : UserControl
    {
        public Vehiclesus()
        {
            InitializeComponent();
        }
        public static string setvalueforvehicle1;
        public static string setvalueforvehicle2;

        private void Vehiclesus_Load(object sender, EventArgs e)
        {
            string source = @"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string sqlselectquery = "select * from sell where category = 'vehicles' order by p_id asc ";

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

        private void Vehiclesus_MouseHover(object sender, EventArgs e)
        {

            string source = @"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";

            SqlConnection con = new SqlConnection(source);
            con.Open();



            string sqlquery = "select top 2 * from sell where category = 'vehicles' order by p_id desc ";
            SqlCommand com = new SqlCommand(sqlquery, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

                textBox2.Text = (dr["Title"].ToString());
                textBox3.Text = (dr["Price"].ToString());

                richTextBox2.Text = (dr["descrip"].ToString());
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            add_Messages add = new add_Messages();
            add.Show();
            setvalueforvehicle1 = tb_Username.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            add_Messages add = new add_Messages();
            add.Show();
            setvalueforvehicle2 = textBox2.Text;
        }
    }
    
}
