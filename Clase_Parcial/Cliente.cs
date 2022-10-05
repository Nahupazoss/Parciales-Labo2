namespace Clase_Parcial
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private int edad;

        public Cliente(int dni, string nombre, string apellido, string nacionalidad, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.edad = edad;
        }
        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public int Edad { get => edad; }
        public int Dni { get => dni; }
        public string Nacionalidad { get => nacionalidad;}

        /*public override bool Equals(object obj)
        {
            Pasajero passenger = obj as Pasajero;

            return this.dni == dni;
        }*/

    }
}
