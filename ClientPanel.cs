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
    public partial class ClientPanel : Form
    {
        public ClientPanel()
        {
            InitializeComponent();
            button1.Paint += button1_Paint;
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

        private void ClientPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientChooseStall ccs = new ClientChooseStall();    
            ccs.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
