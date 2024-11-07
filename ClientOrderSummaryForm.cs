using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quick_Byte.ClientMenuList;

namespace Quick_Byte
{
    public partial class ClientOrderSummaryForm : Form
    {
        // Dictionary to store quantities for each item based on its unique identifier
        private Dictionary<int, int> itemQuantities = new Dictionary<int, int>();

        public ClientOrderSummaryForm()
        {
            InitializeComponent();
            LoadOrderSummary();
        }

        private void ClientOrderSummaryForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadOrderSummary()
        {
            flowLayoutOrderSummary.Controls.Clear(); // Clear existing controls
            decimal total = 0;

            // Loop through each selected item
            foreach (var item in OrderData.SelectedItems)
            {
                // Initialize quantity in the dictionary if it hasn't been added yet
                if (!itemQuantities.ContainsKey(item.Id))
                {
                    itemQuantities[item.Id] = 1; // Default quantity is 1
                }

                // Add the item panel for each menu item
                Panel itemPanel = CreateOrderItemPanel(item);
                flowLayoutOrderSummary.Controls.Add(itemPanel);

                // Calculate total based on current quantity in dictionary
                total += item.Price * itemQuantities[item.Id];
            }

            // Display the total amount
            lblTotalAmount.Text = $"Total: Php {total:F2}";
        }

        // Helper method to create an item panel with name, quantity, and price
        private Panel CreateOrderItemPanel(OrderItem item)
        {
            Panel panel = new Panel
            {
                Size = new Size(flowLayoutOrderSummary.Width - 40, 50),
                Margin = new Padding(10, 5, 10, 5),
                BorderStyle = BorderStyle.None
            };

            // Remove button
            Button btnRemove = new Button
            {
                Text = "✖",
                Size = new Size(25, 25),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Navy,
                Location = new Point(5, 5),
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Click += (s, e) => RemoveItem(item);

            // Item name label
            Label lblName = new Label
            {
                Text = item.Name,
                AutoSize = true,
                Location = new Point(40, 10),
                Font = new Font("Arial", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Quantity controls with custom styling
            Button btnDecrease = new Button
            {
                Text = "−",
                Size = new Size(25, 25),
                Location = new Point(200, 5),
                BackColor = Color.Navy,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            btnDecrease.FlatAppearance.BorderSize = 0;
            btnDecrease.Click += (s, e) => UpdateQuantity(item, -1);

            TextBox txtQuantity = new TextBox
            {
                Text = itemQuantities[item.Id].ToString(), // Display the initial quantity
                Size = new Size(30, 25),
                Location = new Point(230, 5),
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = true,
                Tag = item.Id, // Set Tag to item.Id for easy identification
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };

            Button btnIncrease = new Button
            {
                Text = "+",
                Size = new Size(25, 25),
                Location = new Point(260, 5),
                BackColor = Color.Navy,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            btnIncrease.FlatAppearance.BorderSize = 0;
            btnIncrease.Click += (s, e) => UpdateQuantity(item, 1);

            // Price label - make sure it is added to the panel
            Label lblPrice = new Label
            {
                Text = $"PHP {item.Price * itemQuantities[item.Id]:F2}", // Display initial total for the item
                AutoSize = true,
                Location = new Point(300, 10),
                Font = new Font("Arial", 10),
                Tag = item.Id // Set Tag to item.Id for easy identification
            };

            // Add controls to the item panel
            panel.Controls.Add(btnRemove);
            panel.Controls.Add(lblName);
            panel.Controls.Add(btnDecrease);
            panel.Controls.Add(txtQuantity);
            panel.Controls.Add(btnIncrease);
            panel.Controls.Add(lblPrice); // Ensure lblPrice is added to the panel

            return panel;
        }


        public class OrderSummary
        {
            public List<OrderItem> Items { get; set; } = new List<OrderItem>();
            public Dictionary<int, int> ItemQuantities { get; set; } = new Dictionary<int, int>();
            public decimal Total { get; set; }
        }



        // Method to update the quantity of an item and refresh the summary
        private void UpdateQuantity(OrderItem item, int delta)
        {
            // Update quantity in dictionary
            itemQuantities[item.Id] = Math.Max(1, itemQuantities[item.Id] + delta); // Ensure quantity is at least 1

            // Find the TextBox and Label controls for this item by Tag (item.Id) and update them
            foreach (Control control in flowLayoutOrderSummary.Controls)
            {
                if (control is Panel panel)
                {
                    // Locate the TextBox and Price Label within the panel by matching Tag with item.Id
                    TextBox txtQuantity = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Tag != null && (int)tb.Tag == item.Id);
                    Label lblPrice = panel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Tag != null && (int)lbl.Tag == item.Id);

                    if (txtQuantity != null && lblPrice != null)
                    {
                        // Update the quantity and price display
                        txtQuantity.Text = itemQuantities[item.Id].ToString();
                        lblPrice.Text = $"PHP {item.Price * itemQuantities[item.Id]:F2}";
                    }
                }
            }

            // Refresh total
            lblTotalAmount.Text = $"Total: Php {itemQuantities.Sum(q => q.Value * OrderData.SelectedItems.First(i => i.Id == q.Key).Price):F2}";
        }


        // Method to remove an item from the order and refresh the summary
        private void RemoveItem(OrderItem item)
        {
            OrderData.SelectedItems.Remove(item);
            itemQuantities.Remove(item.Id); // Remove from quantities dictionary
            LoadOrderSummary(); // Refresh the order summary display
        }

        private void btnProceed_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;

            // Define the gradient colors
            Color startColor = Color.Navy;
            Color endColor = Color.Red;

            // Create the gradient brush
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(button.ClientRectangle, startColor, endColor, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                // Fill the button with the gradient
                e.Graphics.FillRectangle(brush, button.ClientRectangle);
            }

            // Draw rounded corners
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20; // Radius for rounded corners
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the button's Region to make it rounded
            button.Region = new Region(path);

            // Draw the text in the center of the button
            TextRenderer.DrawText(e.Graphics, button.Text, button.Font, button.ClientRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClientMenuList cml = new ClientMenuList();
            cml.Show();
            this.Hide();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Create an instance of OrderSummary
            OrderSummary orderSummary = new OrderSummary
            {
                Total = itemQuantities.Sum(q => q.Value * OrderData.SelectedItems.First(i => i.Id == q.Key).Price)
            };

            // Add items and quantities to the order summary
            foreach (var item in OrderData.SelectedItems)
            {
                orderSummary.Items.Add(item);
                orderSummary.ItemQuantities[item.Id] = itemQuantities[item.Id];
            }

            // Pass the order summary to the payment form
            ClientPaymentForm paymentForm = new ClientPaymentForm(orderSummary);
            paymentForm.Show();
            this.Hide(); // Hide the current form
        }
    }



}
