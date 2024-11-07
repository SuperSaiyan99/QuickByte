using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quick_Byte
{
    public partial class AddMenuForm : Form
    {
        public event Action RefreshMenuList; // Event to refresh the main menu list

        public AddMenuForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxMenuImage.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount;

            // Validate input fields
            if (string.IsNullOrEmpty(title) || !decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter valid title and amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate if category is selected
            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Category Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = comboBoxCategory.SelectedItem.ToString();

            // Ensure the resources/images folder exists
            string resourcesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "images");
            if (!Directory.Exists(resourcesFolder))
            {
                Directory.CreateDirectory(resourcesFolder);
            }

            // Generate a unique file name for the image
            string imageFileName = $"{Guid.NewGuid()}.jpg"; // Use GUID to ensure unique file names
            string imagePath = Path.Combine(resourcesFolder, imageFileName);

            // Save the image to the resources/images folder
            if (pictureBoxMenuImage.Image != null)
            {
                pictureBoxMenuImage.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("Please select an image for the menu item.", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Store the relative path to the image in the database
            string relativeImagePath = Path.Combine("resources", "images", imageFileName);

            using (Database db = new Database())
            {
                try
                {
                    db.OpenConnection();

                    // Insert the title, amount, picture, and category into the menu_list table
                    string query = "INSERT INTO menu_list (title, amount, picture, category) VALUES (@title, @amount, @picture, @category)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@picture", relativeImagePath); // Store the relative path
                    cmd.Parameters.AddWithValue("@category", category); // Add the selected category

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Menu item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshMenuList?.Invoke();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrEmpty(txtAmount.Text) || txtAmount.Text == ".")
            {
                txtAmount.Text = "0.00"; // Set a default value if the input is invalid
            }

            // Check if the entered key is a digit or control key (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Disallow the key press
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Disallow the key press if a decimal point already exists
            }
        }
    }
}
