using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quick_Byte.ClientOrderSummaryForm;

namespace Quick_Byte
{
    public partial class ClientPaymentForm : Form
    {
        private OrderSummary orderSummary;

        public ClientPaymentForm(OrderSummary summary)
        {
            InitializeComponent();
            this.orderSummary = summary;
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            // Display items, quantities, and total
            foreach (var item in orderSummary.Items)
            {
                int quantity = orderSummary.ItemQuantities[item.Id];
            }


        }

        private void ClientPaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProceed_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;

            // Define the gradient colors
            Color startColor = Color.Navy;
            Color endColor = Color.Red;

         
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(button.ClientRectangle, startColor, endColor, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                
                e.Graphics.FillRectangle(brush, button.ClientRectangle);
            }

      
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20; 
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);

            TextRenderer.DrawText(e.Graphics, button.Text, button.Font, button.ClientRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        public string savePurchasedItems()
        {
            string receiptCode;

            using (Database db = new Database())
            {
                db.OpenConnection();

                // Insert into transactions table and retrieve the transaction ID
                string insertTransactionQuery = "INSERT INTO transactions (customer_receipt_code, amount) VALUES (@code, @amount)";
                MySqlCommand cmd = new MySqlCommand(insertTransactionQuery, db.GetConnection());

                // Generate a unique receipt code (e.g., transaction code)
                receiptCode = Guid.NewGuid().ToString().Substring(0, 8);
                cmd.Parameters.AddWithValue("@code", receiptCode);
                cmd.Parameters.AddWithValue("@amount", orderSummary.Total);
                cmd.ExecuteNonQuery();
                int transactionId = (int)cmd.LastInsertedId;

                // Insert items into purchased_items table
                foreach (var item in orderSummary.Items)
                {
                    int quantity = orderSummary.ItemQuantities[item.Id];
                    decimal price = item.Price;

                    string insertItemQuery = "INSERT INTO purchased_items (transaction_id, item_id, quantity, price) VALUES (@transaction_id, @item_id, @quantity, @price)";
                    MySqlCommand itemCmd = new MySqlCommand(insertItemQuery, db.GetConnection());
                    itemCmd.Parameters.AddWithValue("@transaction_id", transactionId);
                    itemCmd.Parameters.AddWithValue("@item_id", item.Id);
                    itemCmd.Parameters.AddWithValue("@quantity", quantity);
                    itemCmd.Parameters.AddWithValue("@price", price);
                    itemCmd.ExecuteNonQuery();
                }

                db.CloseConnection();
            }

            return receiptCode; // Return the generated receipt code
        }


        private void btnCash_Click(object sender, EventArgs e)
        {
            string transactionCode = savePurchasedItems(); // Get transaction code
            ClientReceipt cr = new ClientReceipt(orderSummary, transactionCode); // Pass orderSummary and transactionCode
            cr.Show();
            this.Hide();
        }

        private void btcnCreditCard_Click(object sender, EventArgs e)
        {
            string transactionCode = savePurchasedItems();
            ClientReceipt cr = new ClientReceipt(orderSummary, transactionCode);
            cr.Show();
            this.Hide();
        }

        private void btnGcash_Click(object sender, EventArgs e)
        {
            string transactionCode = savePurchasedItems();
            ClientReceipt cr = new ClientReceipt(orderSummary, transactionCode);
            cr.Show();
            this.Hide();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string transactionCode = savePurchasedItems();
            ClientReceipt cr = new ClientReceipt(orderSummary, transactionCode);
            cr.Show();
            this.Hide();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClientOrderSummaryForm cosf = new ClientOrderSummaryForm();
            cosf.Show();
            this.Hide();
        }
    }
}
