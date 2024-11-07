namespace Quick_Byte
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          
            Database db = new Database();
            db.InitializeDatabase();


            Application.Run(new Form1()); 
        }
    }
}