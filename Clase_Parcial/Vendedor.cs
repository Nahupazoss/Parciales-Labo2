namespace Clase_Parcial
{
    public class Vendedor
    {
        int id;
        string nombre;
        string usuario;
        string pass;

        public Vendedor(int id, string nombre, string usuario, string pass)
        {
            this.id = id;
            this.nombre = nombre;
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