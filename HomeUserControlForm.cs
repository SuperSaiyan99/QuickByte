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
    public partial class HomeUserControlForm : UserControl
    {
        public HomeUserControlForm()
        {
            InitializeComponent();
        }

        private void HomeUserControlForm_Load(object sender, EventArgs e)
        {
            LoadLatestTransactions();
            ShowTotalSales();
            ShowTotalMenuAvailable();
        }

        private void LoadLatestTransactions()
        {
            Database db = new Database();
            DataTable latestTransactions = db.GetLatestTransactions();
            dataGridView1.DataSource = latestTransactions;
        }

        private void ShowTotalSales()
        {
            Database db = new Database();
            decimal totalSales = db.GetTotalSales();

            labelTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            labelTotalSales.Text = $"{totalSales:C}";

        }

        private void ShowTotalMenuAvailable()
        {
            Database db = new Database();
            int totalSales = (int)db.GetTotalMenuAvailable();

            labelMenuAvailable.TextAlign = ContentAlignment.MiddleCenter;
            labelMenuAvailable.Text = Convert.ToString(totalSales);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadLatestTransactions();
            ShowTotalSales();
            ShowTotalMenuAvailable();
        }
    }
}
