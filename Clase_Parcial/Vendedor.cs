namespace Clase_Parcial
{
    public class Vendedor : Persona
    {
        int id;
        string usuario;
        string pass;

        public Vendedor(int id, string usuario, string pass, string nombre, string apellido, int edad, int dni) : base(nombre, apellido, edad, dni)
        {
            this.id = id;
            this.usuario = usuario;
            this.pass = pass;
        }

        public string Usuario
        {
            get { return usuario; }
        }

        public bool CheckearPassword(string pass)
        {
            return pass == this.pass;
        }
    }
}