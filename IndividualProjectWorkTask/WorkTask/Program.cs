namespace WorkTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Company company = new Company("Alex's company");
            ApplicationConfiguration.Initialize();
            Form1 form1 = new Form1(company);
            form1.Show();
            Application.Run();
        }

        public static void CloseApp()
        {
            Application.Exit();
        }
    }
}