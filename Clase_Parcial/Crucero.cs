namespace Clase_Parcial
{
    public class Crucero
    {
        string matricula;
        string nombre;
        int cantidadCamarotes;
        int cantidadSalones;
        int cantidadCasinos;
        int capacidadBodega;

        public Crucero(string matricula, string nombre, int cantidadCamarotes, int cantidadSalones, int cantidadCasinos, int capacidadBodega)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadSalones = cantidadSalones;
            this.cantidadCasinos = cantidadCasinos;
            this.capacidadBodega = capacidadBodega;
        }

        public string Nombre { get => nombre; }
        public string Matricula { get => matricula; }
        public int CantidadCamarotes { get => cantidadCamarotes; }
        public int CantidadSalones { get => cantidadSalones; }
        public int CantidadCasinos { get => cantidadCasinos; }
        public int CapacidadBodega { get => capacidadBodega; }

        public override string ToString()
        {
            return matricula.ToString();
        }
    }
}
