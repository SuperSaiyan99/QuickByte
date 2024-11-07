using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Quick_Byte
{
    public partial class Form1 : Form
    {

        public int timeLeft {  get; set; }

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLeft = 1; 
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft -= 1;
            }
            else
            {
                timer1.Stop();
                new WelcomeForm().Show();
                this.Hide();
            }
          
        }
    }
}
