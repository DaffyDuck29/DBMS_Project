using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class InsertAdd : Form
    {
        public InsertAdd()
        {
            InitializeComponent();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String query = "INSERT INTO add (title,description,price) VALUES (@title,@description,@price)";

            //using (SqlCommand command = new SqlCommand(query, con))
            //{
            //    command.Parameters.AddWithValue("@title", textBox1.Text);
            //    command.Parameters.AddWithValue("@description", richTextBox1.Text);
            //    command.Parameters.AddWithValue("@price", textBox2.Text);

            //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
            //    con.Open();
            //    int result = command.ExecuteNonQuery();

            //    Check Error
            //    if (result < 0)
            //        Console.WriteLine("Error inserting data into Database!");
            //    con.Close();
            //}
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into sell (title,descrip,price,category) values('" + textBox1.Text + "','" + richTextBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Ad Inserted Successfully");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            





      

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainpage main = new Mainpage();
            this.Hide();
            main.Show();
        }
    }
}
