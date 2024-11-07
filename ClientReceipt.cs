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
    public partial class ClientReceipt : Form
    {
        private OrderSummary orderSummary;
        private string transactionCode; // Store the transaction code

        public ClientReceipt(OrderSummary summary, string transactionCode)
        {
            InitializeComponent();
            this.orderSummary = summary;
            this.transactionCode = transactionCode; // Set the transaction code
            LoadReceiptDetails();
        }

        private void LoadReceiptDetails()
        {
            // Set transaction code with prominent display
            lblTransactionCode.Text = transactionCode;
            lblTransactionCode.Font = new Font("Arial", 24, FontStyle.Bold);
            lblTransactionCode.ForeColor = Color.Navy;
            lblTransactionCode.TextAlign = ContentAlignment.MiddleCenter;

            // Loop through each item and add to the receipt layout
            foreach (var item in orderSummary.Items)
            {
                int quantity = orderSummary.ItemQuantities[item.Id];
                decimal totalPrice = item.Price * quantity;

                // Create a panel for each item to contain the row elements
                Panel itemPanel = new Panel
                {
                    Size = new Size(flowLayoutReceipt.Width, 25), // Adjust height for a single row
                    Padding = new Padding(0, 0, 0, 5),
                    BorderStyle = BorderStyle.None
                };

                // Quantity label
                Label lblQuantity = new Label
                {
                    Text = $"{quantity}",
                    AutoSize = false,
                    Width = 30,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Arial", 10)
                };

                // Item name label
                Label lblName = new Label
                {
                    Text = item.Name,
                    AutoSize = false,
                    Width = 180,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Arial", 10)
                };

                // Price label, right-aligned
                Label lblPrice = new Label
                {
                    Text = $"PHP {totalPrice:F2}",
                    AutoSize = false,
                    Width = 70,
                    TextAlign = ContentAlignment.MiddleRight,
                    Font = new Font("Arial", 10)
                };

                // Add the labels to the item panel
                itemPanel.Controls.Add(lblQuantity);
                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(lblPrice);

                // Adjust positioning within item panel
                lblQuantity.Location = new Point(5, 0);
                lblName.Location = new Point(40, 0);
                lblPrice.Location = new Point(220, 0);

                // Add the item panel to the flow layout
                flowLayoutReceipt.Controls.Add(itemPanel);
            }

            // Add a separator line after the items
            Label separator = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                AutoSize = false,
                Width = flowLayoutReceipt.Width - 20,
                Height = 2,
                Margin = new Padding(10, 5, 10, 5)
            };
            flowLayoutReceipt.Controls.Add(separator);

            // Display the subtotal amount
            Label lblSubtotal = new Label
            {
                Text = $"Subtotal PHP {orderSummary.Total:F2}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Navy,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Width = flowLayoutReceipt.Width - 20,
                Margin = new Padding(0, 10, 10, 0)
            };
            flowLayoutReceipt.Controls.Add(lblSubtotal);
        }


        private void ClientReceipt_Load(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Paint(object sender, PaintEventArgs e)
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

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ClientPanel cp = new ClientPanel();
            cp.Show();
            this.Close();
        }
    }
}
