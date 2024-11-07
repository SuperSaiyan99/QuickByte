using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;


namespace Quick_Byte
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Define the corner radius
                int cornerRadius = 20;

                // Create a GraphicsPath to define the rounded rectangle
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
                path.AddArc(new Rectangle(button.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
                path.AddArc(new Rectangle(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
                path.AddArc(new Rectangle(0, button.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
                path.CloseFigure();

                // Set the button's region to the rounded rectangle path
                button.Region = new Region(path);

                // Optionally draw the background and text manually if you want specific styles
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(button.BackColor), path);
                TextRenderer.DrawText(e.Graphics, button.Text, button.Font, button.ClientRectangle, button.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Assuming you have a Database class for MySQL connection
            Database db = new Database();
            bool isAuthenticated = false;

            try
            {
                db.OpenConnection();
                string query = "SELECT password_hash FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHash = reader.GetString("password_hash");

                        string enteredHash = HashPassword(password);
                        isAuthenticated = enteredHash == storedHash;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            return isAuthenticated;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (AuthenticateUser(username, password))
            {

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                AdminDashboard mainForm = new AdminDashboard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm wc = new WelcomeForm();
            wc.Show();
            this.Close();
        }
    }
}
