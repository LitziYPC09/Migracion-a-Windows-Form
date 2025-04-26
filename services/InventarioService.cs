using System.Collections.Generic;
using MinecraftManager.Models;
using MinecraftManager.Utils;

namespace MinecraftManager.Services
{
    public class InventarioService
    {
        private readonly DatabaseManager _dbManager;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;

        public InventarioService(DatabaseManager dbManager, JugadorService jugadorService, BloqueService bloqueService)
        {
            _dbManager = dbManager;
            _jugadorService = jugadorService;
            _bloqueService = bloqueService;
        }

        public void Agregar(Inventario inventario)
        {
            // Implementación para agregar un elemento al inventario
        }

        public List<Inventario> ObtenerTodos()
        {
            // Implementación para obtener todo el inventario
            return new List<Inventario>();
        }

        public void Actualizar(Inventario inventario)
        {
            // Implementación para actualizar un elemento del inventario
        }

        public void Eliminar(int id)
        {
            // Implementación para eliminar un elemento del inventario
        }
    }
}
