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
    public partial class ClientChooseStall : Form
    {
        public ClientChooseStall()
        {
            InitializeComponent();
        }

        private void ClientChooseStall_Load(object sender, EventArgs e)
        {
            LoadStalls();
        }

        public static class SelectedStall
        {
            public static int StallId { get; set; }
            public static string StallName { get; set; }
            public static string LogoPath { get; set; }
        }

        public void LoadStalls()
        {
            Database db = new Database();
            DataTable stallTable = db.GetStalls();

            flowLayoutStall.Controls.Clear();

            foreach (DataRow row in stallTable.Rows)
            {
                int stallId = Convert.ToInt32(row["stall_id"]);
                string stallName = row["name"].ToString();
                string logoPath = row["logo_path"].ToString();

                Panel panel = new Panel
                {
                    Size = new Size(200, 250),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Margin = new Padding(20)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(180, 180),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                string fullLogoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logoPath);
                if (File.Exists(fullLogoPath))
                {
                    pictureBox.Image = Image.FromFile(fullLogoPath);
                }
                else
                {
                    pictureBox.Image = Properties.Resources.RedDot_Burger;
                }

                panel.Controls.Add(pictureBox);

                Label lblName = new Label
                {
                    Text = stallName,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(180, 40),
                    Location = new Point(10, 200),
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.Navy
                };

                panel.Controls.Add(lblName);

                // Attach the Stall_Click event to the panel, picture box, and label
                panel.Click += (s, e) => Stall_Click(stallId, stallName, logoPath);
                pictureBox.Click += (s, e) => Stall_Click(stallId, stallName, logoPath);
                lblName.Click += (s, e) => Stall_Click(stallId, stallName, logoPath);

                flowLayoutStall.Controls.Add(panel);
            }
        }


        // Event handler for when a stall is clicked
        private void Stall_Click(int stallId, string stallName, string logoPath)
        {
            // Store the selected stall information in the global SelectedStall class
            SelectedStall.StallId = stallId;
            SelectedStall.StallName = stallName;
            SelectedStall.LogoPath = logoPath;

            ClientMenuList cml = new ClientMenuList();
            cml.Show();
            this.Close();
        }





    }
}
