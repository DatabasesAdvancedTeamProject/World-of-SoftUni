namespace WorldOfSoftuniRPG
{
    using System;
    using System.Windows.Forms;

    using WorldOfSoftuniRPG.Forms;

    internal static class MainGame
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}