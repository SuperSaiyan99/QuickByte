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

namespace Quick_Byte
{
    public partial class MenuItemsUserControlForm : UserControl
    {
        public MenuItemsUserControlForm()
        {
            InitializeComponent();
        }

        private void MenuItemsUserControlForm_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }


        private void LoadMenuItems()
        {
            Database db = new Database();
            DataTable menuItems = db.GetMenuItems();

            // Clear existing controls if reloading
            flowLayoutPanelMenu.Controls.Clear(); // Assuming you're using a FlowLayoutPanel for layout

            foreach (DataRow row in menuItems.Rows)
            {
                // Retrieve data from each row
                int menuId = Convert.ToInt32(row["menu_id"]);
                string title = row["title"].ToString();
                decimal amount = Convert.ToDecimal(row["amount"]);
                string picturePath = row["picture"].ToString(); // Path to the image file

                // Create a new Panel for each menu item
                Panel panel = new Panel
                {
                    Size = new Size(150, 200), // Adjust size as needed
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightCoral
                };

                // Add Label for the title
                Label lblTitle = new Label
                {
                    Text = title,
                    AutoSize = true,
                    Location = new Point(10, 10),
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                panel.Controls.Add(lblTitle);

                // Add PictureBox for the image
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(10, 30),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Load the image from the file path and display it
                if (!string.IsNullOrEmpty(picturePath))
                {
                    string fullImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, picturePath);
                    if (File.Exists(fullImagePath))
                    {
                        pictureBox.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        // Optionally set a default image if the file is missing
                        pictureBox.Image = Properties.Resources.RedDot_Burger; 
                    }
                }
                panel.Controls.Add(pictureBox);

                // Add Label for the price
                Label lblPrice = new Label
                {
                    Text = $"${amount:F2}",
                    AutoSize = true,
                    Location = new Point(10, 140),
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                panel.Controls.Add(lblPrice);

                // Add Delete button
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Size = new Size(60, 25),
                    Location = new Point(10, 170),
                    BackColor = Color.Yellow
                };

                // Add a Click event for the Delete button
                btnDelete.Click += (s, e) => DeleteMenuItem(menuId, panel);
                panel.Controls.Add(btnDelete);

                // Add the panel to the FlowLayoutPanel or main container
                flowLayoutPanelMenu.Controls.Add(panel);
            }
        }

        // Method to delete a menu item from the database and remove the panel
        private void DeleteMenuItem(int menuId, Panel panel)
        {
            Database db = new Database();

            try
            {
                db.OpenConnection();
                string deleteQuery = "DELETE FROM menu_list WHERE menu_id = @menuId";
                MySqlCommand cmd = new MySqlCommand(deleteQuery, db.GetConnection());
                cmd.Parameters.AddWithValue("@menuId", menuId);

                cmd.ExecuteNonQuery();

                // Remove the panel from the FlowLayoutPanel after deletion
                flowLayoutPanelMenu.Controls.Remove(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of AddMenuForm
            AddMenuForm addMenuForm = new AddMenuForm();

            // Optionally subscribe to the RefreshMenuList event if you have that implemented
            addMenuForm.RefreshMenuList += LoadMenuItems;

            // Show the form as a dialog
            addMenuForm.ShowDialog();
        }
    }
}
