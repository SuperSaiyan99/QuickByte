using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quick_Byte
{
    public partial class AddStallForm : Form
    {
        public event Action RefreshStallList; // Event to refresh the main form stall list

        public AddStallForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stallName = txtStallName.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(stallName))
            {
                MessageBox.Show("Please enter a valid stall name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure the resources/logos folder exists
            string logosFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "logos");
            if (!Directory.Exists(logosFolder))
            {
                Directory.CreateDirectory(logosFolder);
            }

            // Generate a unique file name for the logo image
            string logoFileName = $"{Guid.NewGuid()}.jpg";
            string logoPath = Path.Combine(logosFolder, logoFileName);

            // Save the logo image to the resources/logos folder
            if (pictureBoxStallLogo.Image != null)
            {
                pictureBoxStallLogo.Image.Save(logoPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("Please select a logo for the stall.", "Logo Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Store the relative path to the logo in the database
            string relativeLogoPath = Path.Combine("resources", "logos", logoFileName);

            using (Database db = new Database())
            {
                try
                {
                    db.OpenConnection();

                    string query = "INSERT INTO stall_list (name, logo_path) VALUES (@name, @logo_path)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@name", stallName);
                    cmd.Parameters.AddWithValue("@logo_path", relativeLogoPath);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stall added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Trigger the event to refresh the main stall list
                    RefreshStallList?.Invoke();

                    this.Close(); // Close the form after saving
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
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStallLogo.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
