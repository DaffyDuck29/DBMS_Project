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
    public partial class Mainpage : Form
    {
        public Mainpage()
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

        private void Btn_Selectcategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            this.Hide();
            categories.Show();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertAdd insertAdd = new InsertAdd();
            this.Hide();
            insertAdd.Show();
        }

     

        private void btn_browseadds_Click(object sender, EventArgs e)
        {
            Browse_Ads browse = new Browse_Ads();
            this.Hide();
            browse.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Firstpage f1 = new Firstpage();
            this.Hide();
            f1.Show();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Messages message = new Messages();
            this.Hide();
            message.Show();
            
        }

        private void lbl_forward_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainpage_Load(object sender, EventArgs e)
        {

            lbl_forward.Text = Loginwindow.SetValueForText1;
        }
    }
}
