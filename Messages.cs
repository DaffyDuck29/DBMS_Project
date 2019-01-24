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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainpage main = new Mainpage();
            this.Hide();
            main.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string source = @"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";

            SqlConnection con = new SqlConnection(source);
            con.Open();



            string sqlquery = "select top 1 * from message ";
            SqlCommand com = new SqlCommand(sqlquery, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

                textBox1.Text = (dr["detofadd"].ToString());



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string source = @"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";

            SqlConnection con = new SqlConnection(source);
            con.Open();



            string sqlquery = "select top 1 * from message order by msgid desc ";
            SqlCommand com = new SqlCommand(sqlquery, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

                textBox2.Text = (dr["detofadd"].ToString());



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(l_mob1.Text != "" || lmob2.Text != ""   )
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete message where detofadd =('" + textBox1.Text + "')";
                        cmd.ExecuteNonQuery();

                        con.Close();
                        Messages add = new Messages();
                        this.Hide();
                        add.Show();
                       
                    }
                    catch
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("You havent completed the transaction");
                }

            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete message where detofadd =('" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Transaction Completed ");
                Messages add = new Messages();
                this.Hide();
                add.Show();
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete message where message.detofadd =('" + textBox2.Text + "')  ";
                cmd.ExecuteNonQuery();

                con.Close();
                
                MessageBox.Show("Transaction Completed ");
                Messages add = new Messages();
                this.Hide();
                add.Show();
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete message where detofadd =('" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Transaction Completed ");
                Messages add = new Messages();
                this.Hide();
                add.Show();
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void lblmes_Click(object sender, EventArgs e)
        {

        }

        private void Messages_Load(object sender, EventArgs e)
        {
            l_mob1.Text = add_Messages.SetvalueforMob1;
            lmob2.Text = add_Messages.SetvalueforMob2;
            lelectonic1.Text = add_Messages.SetvalueforElect1;
            lelectronic2.Text = add_Messages.SetvalueforElect2;
            lfash1.Text = add_Messages.setvalueforfash1;
            lfash2.Text = add_Messages.setvalueforfash2;
            lfurn1.Text = add_Messages.Setvalueforfurniture1;
            lfurn2.Text = add_Messages.setvalueforfurniture2;
            lhobby1.Text = add_Messages.Setvalueforhobies1;
            lhobby2.Text = add_Messages.setvalueforhobbies2;
            ljob1.Text = add_Messages.setvalueforjob1;
            ljob2.Text = add_Messages.setvalueforjob2;

            lkids1.Text = add_Messages.setvalueforkids1;
            lkids2.Text = add_Messages.setvalueforkids2;
            lprop1.Text = add_Messages.setvalueforprop1;
            lprop2.Text = add_Messages.setvalueforprop2;
            lserv1.Text = add_Messages.setvalueforservices1;
            lserv2.Text = add_Messages.setvalueforservices2;

            lvehicles1.Text = add_Messages.setvalueforvehicle1;
            lvehicles2.Text = add_Messages.setvalueforvehicle2;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
          
        }
    }
}