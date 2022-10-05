using System;

namespace Clase_Parcial
{
    public static class Validador
    {
        public static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato);
        }

        /*public static bool ValidarNumeroEntero(int dato)
        {
            bool validar = int.TryParse( "s", out dato);
            return validar;
        }*/

        /*public static bool ChekearDniCliente(int dni,)
        {
            foreach (var item in collection)
            {

            }
            
        }*/


    }
}
