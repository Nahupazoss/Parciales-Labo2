using System;

namespace Clase_Parcial
{
    public static class Validador
    {
        public static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato);
        }

        /*public static bool ChekearDniCliente(int dni,)
        {
            foreach (var item in collection)
            {

            }     
        }*/
        public static bool ValidacionStrings(string nomb, string apellido, string nacionalidad)
        {
            return Validador.ValidarTexto(nomb) && Validador.ValidarTexto(apellido) && Validador.ValidarTexto(nacionalidad);
        }

    }
}
