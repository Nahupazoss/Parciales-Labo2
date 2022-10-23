namespace Clase_Parcial
{
    public class Cliente : Persona
    {
        private string nacionalidad;

        public Cliente(string nombre, string apellido, int edad, int dni, string nacionalidad) : base(nombre,apellido,edad,dni)
        {
            this.nacionalidad = nacionalidad;
        }

        public string Nacionalidad { get => nacionalidad;}

        /*public override bool Equals(object obj)
        {
            Pasajero passenger = obj as Pasajero;

            return this.dni == dni;
        }*/

    }
}
