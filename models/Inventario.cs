namespace MinecraftManager.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int JugadorId { get; set; }
        public int BloqueId { get; set; }
        public int Cantidad { get; set; }
        public string NombreJugador { get; set; }
        public string NombreBloque { get; set; }

        public override string ToString()
        {
            return $"{NombreJugador} - {NombreBloque}: {Cantidad}";
        }
    }
}
