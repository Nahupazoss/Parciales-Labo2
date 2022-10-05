using System;
using System.Collections.Generic;

namespace Clase_Parcial
{
    public class Viaje
    {
        //private List<Pasajero> pasajeros;
        Crucero crucero;
        int horasViaje;
        string tipoViaje;
        string origen;
        string destino;
        DateTime salida;
        DateTime llegada;
        float precioPasaje;

        public Viaje(Crucero crucero, int horasViaje, string tipoViaje, string origen, string destino, DateTime salida, DateTime llegada, float precioPasaje)
        {
            this.crucero = crucero;
            this.horasViaje = horasViaje;
            this.tipoViaje = tipoViaje;
            this.origen = origen;
            this.destino = destino;
            this.salida = salida;
            this.llegada = llegada;
            this.precioPasaje = precioPasaje;
        }

        public string Crucero { get => crucero.Matricula; }
        public string TipoViaje { get => tipoViaje; }
        public string Origen { get => origen; }
        public string Destino { get => destino; }
        public int HorasViaje { get => horasViaje; }
        public DateTime Salida { get => salida; }
        public DateTime Llegada { get => llegada; }
        public float PrecioPasaje { get => precioPasaje; }

        public Crucero ObtenerCruceroOBJ()
        {
            return crucero;
        }

        


    }
}