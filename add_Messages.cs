using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class add_Messages : Form
    {
        public add_Messages()
        {
            InitializeComponent();
        }

   
         public static string SetvalueforMob1;
        public static string SetvalueforMob2;
        public static string SetvalueforElect1;
        public static string SetvalueforElect2;
        public static string setvalueforfash1;
        public static string setvalueforfash2;
        public static string Setvalueforfurniture1;
        public static string setvalueforfurniture2;
        public static string Setvalueforhobies1;
        public static string setvalueforhobbies2;
        public static string setvalueforjob1;
        public static string setvalueforjob2;

        public static string setvalueforkids1;
        public static string setvalueforkids2;
        public static string setvalueforprop1;
        public static string setvalueforprop2;
        public static string setvalueforservices1;
        public static string setvalueforservices2;

        public static string setvalueforvehicle1;
        public static string setvalueforvehicle2;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_done_register_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O8UDH05;Initial Catalog=APRO;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into message(detofadd) values('" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Messages sent successfully");
                    this.Close();
                    
                   
                }
                catch
                {
                    MessageBox.Show("Failed");
                    if(textBox1.Text=="")
                    {
                        MessageBox.Show("Please Enter your message with contact id");
                    }
                    MessageBox.Show("Please Enter your message with contact id ");
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void add_Messages_Load(object sender, EventArgs e)
        {

            l_mob1.Text = Mobilesuc.SetvalueforMob1;
            lmob2.Text = Mobilesuc.SetvalueforMob2;
            lelectonic1.Text = Electronicsus.SetvalueforElect1;
            lelectronic2.Text = Electronicsus.SetvalueforElect2;
            lfash1.Text = fashionsus.setvalueforfash1;
            lfash2.Text = fashionsus.setvalueforfash2;
            lfurn1.Text = Furnituresus.Setvalueforfurniture1;
            lfurn2.Text = Furnituresus.setvalueforfurniture2;
            lhobby1.Text = Hobbiesus.Setvalueforhobies1;
            lhobby2.Text = Hobbiesus.setvalueforhobbies2;
            ljob1.Text = Jobsus.setvalueforjob1;
            ljob2.Text = Jobsus.setvalueforjob2;

            lkids1.Text = Kidsus.setvalueforkids1;
            lkids2.Text = Kidsus.setvalueforkids2;
            lprop1.Text = Propertiesus.setvalueforprop1;
            lprop2.Text = Propertiesus.setvalueforprop2;
            lserv1.Text = Servicesus.setvalueforservices1;
            lserv2.Text = Servicesus.setvalueforservices2;

            lvehicles1.Text = Vehiclesus.setvalueforvehicle1;
            lvehicles2.Text = Vehiclesus.setvalueforvehicle2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
