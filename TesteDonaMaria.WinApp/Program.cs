using System;
using System.Windows.Forms;
using TesteDonaMaria.Infra.Arquivos;

namespace TesteDonaMaria.WinApp
{
    internal static class Program
    {
        static ISerializador serializador = new SerializadorDadosEmJsonDotnet();

        static DataContext contexto = new DataContext(serializador);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal(contexto));

            contexto.GravarDados();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            contexto.GravarDados();
        }
    }
}
