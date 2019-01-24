using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_PROJECT_AA_PRODUCTION_
{
    public partial class Categories_2 : Form
    {
        public Categories_2()
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
            pictureBox2.ImageLocation = string.Format(@"pictures\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            this.Hide();
            categories.Show();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mobile_Click(object sender, EventArgs e)
        {
            servicesus1.BringToFront();
        }

        private void btn_electronics_Click(object sender, EventArgs e)
        {
            fashionsus1.BringToFront();
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            furnituresus1.BringToFront();
        }

        private void btn_property_Click(object sender, EventArgs e)
        {
            hobbiesus1.BringToFront();
        }

        private void btn_jobs_Click(object sender, EventArgs e)
        {
            kidsus1.BringToFront();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
