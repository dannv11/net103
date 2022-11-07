namespace BAI_1_4_GROUPBOX_PANEL
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
            ApplicationConfiguration.Initialize();
            // truyền vào form sẽ chạy khi bắt đầu chương trình
            Application.Run(new Form3());
        }
    }
}