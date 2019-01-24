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
    public partial class Browse_Ads : Form
    {
        public Browse_Ads()
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

        private void Btn_searchitems_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            this.Hide();
            categories.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainpage main = new Mainpage();
            this.Hide();
            main.Show();
        }

      
        private void Browse_Ads_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            browse11.BringToFront();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            browse21.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            browse31.BringToFront();
        }

        private void browse31_Load(object sender, EventArgs e)
        {

        }
    }
}
