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
using System.Data.Sql;

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        //logic for slide image jis m image number pheli image ka number h phir "LoadNextImage" k naam ki aik private class declare kri jo timer m lage ki tho resulting sliding images
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 15)
            {
                imageNumber = 1;

            }
           pictureBox2.ImageLocation = string.Format(@"Pictures\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
           


        }

        private void btn_mobile_Click(object sender, EventArgs e)
        {
            mobilesuc1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Categories_2 categories_2 = new Categories_2();
            this.Hide();
            categories_2.Show();
        }

        private void btn_electronics_Click(object sender, EventArgs e)
        {
            electronicsus1.BringToFront();
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            vehiclesus1.BringToFront();
        }

        private void vehiclesus1_Load(object sender, EventArgs e)
        {

        }

        private void btn_property_Click(object sender, EventArgs e)
        {
            propertiesus1.BringToFront();
        }

        private void btn_jobs_Click(object sender, EventArgs e)
        {
            jobsus1.BringToFront();
        }

        private void jobsus1_Load(object sender, EventArgs e)
        {

        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage();
            this.Hide();
            mainpage.Show();
        }

        private void jobsus1_Load_1(object sender, EventArgs e)
        {

           
        }
    }
}
