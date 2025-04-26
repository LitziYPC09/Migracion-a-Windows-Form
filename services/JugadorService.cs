using System.Collections.Generic;
using MinecraftManager.Models;
using MinecraftManager.Utils;

namespace MinecraftManager.Services
{
    public class JugadorService
    {
        private readonly DatabaseManager _dbManager;

        public JugadorService(DatabaseManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void Crear(Jugador jugador)
        {
            // Implementaci�n para agregar un jugador a la base de datos
        }

        public List<Jugador> ObtenerTodos()
        {
            // Implementaci�n para obtener todos los jugadores
            return new List<Jugador>();
        }

        public Jugador ObtenerPorId(int id)
        {
            // Implementaci�n para obtener un jugador por ID
            return null;
        }

        public void Actualizar(Jugador jugador)
        {
            // Implementaci�n para actualizar un jugador
        }

        public void Eliminar(int id)
        {
            // Implementaci�n para eliminar un jugador
        }
    }
}
