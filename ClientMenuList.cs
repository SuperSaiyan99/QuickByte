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
    public partial class ClientMenuList : Form
    {

        private Dictionary<int, (string, decimal)> selectedItems = new Dictionary<int, (string, decimal)>();

        private void AddItemToSelection(int itemId, string itemName, decimal price)
        {
            if (!selectedItems.ContainsKey(itemId))
            {
                selectedItems.Add(itemId, (itemName, price));

                Panel selectedItemPanel = new Panel
                {
                    Size = new Size(200, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                Label lblItemName = new Label
                {
                    Text = itemName,
                    AutoSize = false,
                    Size = new Size(100, 50),
                    Location = new Point(10, 10),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label lblItemPrice = new Label
                {
                    Text = $"${price:F2}",
                    AutoSize = false,
                    Size = new Size(70, 30),
                    Location = new Point(120, 10),
                    TextAlign = ContentAlignment.MiddleRight
                };

                selectedItemPanel.Controls.Add(lblItemName);
                selectedItemPanel.Controls.Add(lblItemPrice);
                flowLayoutItemList.Controls.Add(selectedItemPanel);

                UpdateTotal();
            }
        }

        public class OrderItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public static class OrderData
        {
            public static List<OrderItem> SelectedItems = new List<OrderItem>();
        }

        private void UpdateTotal()
        {
            decimal total = selectedItems.Values.Sum(item => item.Item2);
            textTotalSum.Text = $"${total:F2}";
        }

        public ClientMenuList()
        {
            InitializeComponent();
        }

        private void ClientMenuList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
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

        private void LoadMenuItems(string category = null)
        {
            Database db = new Database();
            DataTable menuItems;

            if (string.IsNullOrEmpty(category))
            {
                menuItems = db.GetAllMenuItems();
            }
            else
            {
                menuItems = db.GetMenuItemsByCategory(category);
            }

            flowLayoutMenuList.Controls.Clear();

            foreach (DataRow row in menuItems.Rows)
            {
                int itemId = Convert.ToInt32(row["menu_id"]);
                string itemName = row["title"].ToString();
                decimal price = Convert.ToDecimal(row["amount"]);
                string imagePath = row["picture"].ToString();

                Panel itemPanel = new Panel
                {
                    Size = new Size(200, 250),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(160, 160),
                    Location = new Point(10, 10),
                    ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label lblName = new Label
                {
                    Text = itemName,
                    AutoSize = false,
                    Size = new Size(160, 30),
                    Location = new Point(10, 180),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label lblPrice = new Label
                {
                    Text = $"${price:F2}",
                    AutoSize = false,
                    Size = new Size(160, 30),
                    Location = new Point(10, 210),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Add controls to the panel
                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(lblPrice);

                // Attach Click event to panel and all child controls
                itemPanel.Click += (s, e) => AddItemToSelection(itemId, itemName, price);
                pictureBox.Click += (s, e) => AddItemToSelection(itemId, itemName, price);
                lblName.Click += (s, e) => AddItemToSelection(itemId, itemName, price);
                lblPrice.Click += (s, e) => AddItemToSelection(itemId, itemName, price);

                flowLayoutMenuList.Controls.Add(itemPanel);
            }
        }


        private void btnStudentMeal_Click(object sender, EventArgs e)
        {
            LoadMenuItems("student_meal");
        }

        private void btnViand_Click(object sender, EventArgs e)
        {
            LoadMenuItems("viand");
        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            LoadMenuItems("rice");
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            LoadMenuItems("snacks");
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            LoadMenuItems("beverages");
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            // Transfer selected items to OrderData
            OrderData.SelectedItems.Clear();
            foreach (var item in selectedItems)
            {
                OrderData.SelectedItems.Add(new OrderItem
                {
                    Id = item.Key,              // Pass the itemId here
                    Name = item.Value.Item1,     // Pass the itemName
                    Price = item.Value.Item2     // Pass the price
                });
            }

            // Open the next form (e.g., OrderSummaryForm)
            ClientOrderSummaryForm orderSummaryForm = new ClientOrderSummaryForm();
            orderSummaryForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientChooseStall cs = new ClientChooseStall();
            cs.Show();
            this.Close();
        }
    }
}
