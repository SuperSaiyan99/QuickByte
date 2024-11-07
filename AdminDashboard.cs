using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Byte
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeUserControlForm1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuItemsUserControlForm1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stalluserControlForm1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel loginForm = new AdminPanel();
            loginForm.Show();
            
            this.Close();
        }
    }
}
