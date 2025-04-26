using System;
using System.Windows.Forms;
using MinecraftManager.Services;
using MinecraftManager.UI;
using MinecraftManager.Utils;

namespace MinecraftManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbManager = new DatabaseManager();
            var jugadorService = new JugadorService(dbManager);
            var bloqueService = new BloqueService(dbManager);
            var inventarioService = new InventarioService(dbManager, jugadorService, bloqueService);

            Application.Run(new MainForm(jugadorService, bloqueService, inventarioService));
        }
    }
}
