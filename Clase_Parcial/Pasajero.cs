using System.Collections.Generic;
using System;

namespace Clase_Parcial
{
    public class Pasajero
    {
        Cliente cliente;
        Viaje viaje;
        int pesoEquipaje;
        string equipajeDeMano;

        public Pasajero(Cliente cliente, int pesoEquipaje, string equipajeDeMano,Viaje viaje)
        {
            this.cliente = cliente;
            this.pesoEquipaje = pesoEquipaje;
            this.equipajeDeMano = equipajeDeMano;
            this.viaje = viaje;
        }

        public int Dni { get => cliente.Dni; }
        public string Nombre { get => cliente.Nombre; }
        public string Apellido { get => cliente.Apellido; }
        public int PesoEquipaje { get => pesoEquipaje; }   
        public string EquipajeDeMano { get => equipajeDeMano; }
        public string MatriculaDeViaje { get => viaje.Crucero; }
        public string Destino { get => viaje.Destino; }
        public DateTime Llegada { get => viaje.Llegada; }


    }
}