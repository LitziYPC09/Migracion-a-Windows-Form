using System.Collections.Generic;
using MinecraftManager.Models;
using MinecraftManager.Utils;

namespace MinecraftManager.Services
{
    public class BloqueService
    {
        private readonly DatabaseManager _dbManager;

        public BloqueService(DatabaseManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void Crear(Bloque bloque)
        {
            // Implementación para agregar un bloque a la base de datos
        }

        public List<Bloque> ObtenerTodos()
        {
            // Implementación para obtener todos los bloques
            return new List<Bloque>();
        }

        public Bloque ObtenerPorId(int id)
        {
            // Implementación para obtener un bloque por ID
            return null;
        }

        public void Actualizar(Bloque bloque)
        {
            // Implementación para actualizar un bloque
        }

        public void Eliminar(int id)
        {
            // Implementación para eliminar un bloque
        }
    }
}
