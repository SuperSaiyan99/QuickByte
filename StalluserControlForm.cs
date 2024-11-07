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
    public partial class StalluserControlForm : UserControl
    {
        public StalluserControlForm()
        {
            InitializeComponent();
            
        }

        private void StalluserControlForm_Load(object sender, EventArgs e)
        {
            LoadStalls();
        }


        public void LoadStalls()
        {
            Database db = new Database();
            DataTable stallTable = db.GetStalls();

            // Clear existing controls if reloading
            flowLayoutPanelStalls.Controls.Clear(); // Assuming you're using a FlowLayoutPanel for layout

            foreach (DataRow row in stallTable.Rows)
            {
                int stallId = Convert.ToInt32(row["stall_id"]);
                string stallName = row["name"].ToString();
                string logoPath = row["logo_path"].ToString();

                // Create a new Panel for each stall
                Panel panel = new Panel
                {
                    Size = new Size(120, 160), // Adjust size as needed
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                // Add PictureBox for the logo
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Load the logo image from the file path and display it
                string fullLogoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logoPath);
                if (File.Exists(fullLogoPath))
                {
                    pictureBox.Image = Image.FromFile(fullLogoPath);
                }

                panel.Controls.Add(pictureBox);

                // Add Label for the stall name
                Label lblName = new Label
                {
                    Text = stallName,
                    AutoSize = true,
                    Location = new Point(10, 120),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                panel.Controls.Add(lblName);

                // Add the panel to the FlowLayoutPanel or main container
                flowLayoutPanelStalls.Controls.Add(panel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of AddStallForm
            AddStallForm addStallForm = new AddStallForm();

            // Optionally subscribe to an event to refresh the stall list after adding a new stall
            addStallForm.RefreshStallList += LoadStalls;

            // Show the form as a dialog
            addStallForm.ShowDialog();
        }
    }
}
