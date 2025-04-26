using System;
using System.Windows.Forms;
using MinecraftManager.Services;

namespace MinecraftManager.UI
{
    public partial class MainForm : Form
    {
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private readonly InventarioService _inventarioService;

        public MainForm(JugadorService jugadorService, BloqueService bloqueService, InventarioService inventarioService)
        {
            //InitializeComponent();
            _jugadorService = jugadorService;
            _bloqueService = bloqueService;
            _inventarioService = inventarioService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales
        }
    }
}