using System.Collections.Generic;
using System.Linq;
using System;

namespace Clase_Parcial
{
    public static class Sistema
    {
        static List<Crucero> cruceros;
        static List<Vendedor> vendedores;
        static List<Cliente> clientes;
        static List<Viaje> viajes;
        static List<Pasajero> pasajeros;

        public static List<Cliente> Clientes { get => clientes; }
        public static List<Pasajero> Pasajeros { get => pasajeros; }
        public static List<Crucero> Cruceros { get => cruceros; }
        public static List<Viaje> Viajes { get => viajes; }

        static Sistema()
        {
            cruceros = new List<Crucero>();
            vendedores = new List<Vendedor>();
            clientes = new List<Cliente>();
            pasajeros = new List<Pasajero>();
            viajes = new List<Viaje>();
            HardcodeVendedor();
            HarcodeCrucero();
            HarcodeCliente();
            HardcodeViaje();
            HardCodePasajero();
        }

        private static void HardCodePasajero()
        {
            pasajeros.Add(new Pasajero(Sistema.clientes[0],25,"si",Sistema.viajes[0]));
            pasajeros.Add(new Pasajero(Sistema.clientes[2], 30, "no", Sistema.viajes[0]));
            pasajeros.Add(new Pasajero(Sistema.clientes[7], 35, "si", Sistema.viajes[0]));
            pasajeros.Add(new Pasajero(Sistema.clientes[8], 28, "si", Sistema.viajes[0]));
        }

        private static void HardcodeViaje()
        {
            viajes.Add(new Viaje(Sistema.cruceros[0], 480, "ExtraRegional", "BuenosAires", "Miami", DateTime.Parse("10/10/2022 21:30"), DateTime.Parse("30/11/2022 21:30"),57600f));
        }
        private static void HarcodeCliente()
        {
            clientes.Add(new Cliente(45583107, "Nahuel", "Pazos", "Argentino", 19));
            clientes.Add(new Cliente(24321465, "Nathan", "Sulivan", "Frances", 23));
            clientes.Add(new Cliente(40213421, "Valery", "Pavlov", "Italiano", 33));
            clientes.Add(new Cliente(31213451, "Pablo", "Vidal", "Español", 70));
            clientes.Add(new Cliente(32325145, "Mateo", "Zarza", "Argentino", 55));
            clientes.Add(new Cliente(22341556, "Juan", "Visini", "Estadounidense", 19));
            clientes.Add(new Cliente(29312012, "Agustin", "Scali", "Africano", 30));
            clientes.Add(new Cliente(35234124, "Maria", "Fernanda", "Española", 30));
            clientes.Add(new Cliente(23901234, "Christian", "Pazos", "Suizo", 30));
            clientes.Add(new Cliente(43090212, "Nacho", "Gerla", "Ruso", 22));
            clientes.Add(new Cliente(45021345, "Joaquin", "Orueta", "Español", 24));
        }

        private static void HarcodeCrucero()
        {
            cruceros.Add(new Crucero("AH123ZRT","Crucero DRK High",100,2,0,700));
            cruceros.Add(new Crucero("AH231ZJT", "Crucero DRK Prem", 100, 2, 1, 600));
            cruceros.Add(new Crucero("ZH123AHR", "Crucero DRK Low", 100, 2, 0, 350));
            cruceros.Add(new Crucero("BH123AKL", "Crucero DRK Nashe", 100, 2, 1, 1000));
            cruceros.Add(new Crucero("BH231RLK", "Crucero DRK Lol", 100, 2, 0, 500));
            cruceros.Add(new Crucero("CH123MKL", "Crucero DRK Dam", 100, 2, 0, 200));
            cruceros.Add(new Crucero("CH231NPR", "Crucero DRK Owo", 100, 2, 0, 100));
        }

        private static void HardcodeVendedor()
        {
            vendedores.Add(new Vendedor(1, "Nahuel", "NahuPazos", "123a"));
            vendedores.Add(new Vendedor(2, "Maximiliano", "Neiner", "123aa"));
            vendedores.Add(new Vendedor(3, "Manuela", "ManuLagos", "a123"));
            vendedores.Add(new Vendedor(4, "Jeronimo", "JeroMax", "aa123"));
            vendedores.Add(new Vendedor(5, "a", "a", "a"));
        }

        public static bool LoguearVendedor(string usuario, string pass)
        {
            bool resultado = false;

            foreach (Vendedor auxVendedor in vendedores)
            {
                if (auxVendedor.Usuario == usuario)
                {
                    resultado = auxVendedor.CheckearPassword(pass);
                }
            }
            return resultado;
        }

        public static void ResgistrarEmpleados(string nombre, string usuario, string pass)
        {
            for (int i = 4; i < 100; i++)
            {
                vendedores.Add(new Vendedor(i, nombre, usuario, pass));
            }
        }

        public static void OrdenarEdadMenor(List<Cliente> cliente)
        {
            Cliente aux;

            for(int i = 0; i < cliente.Count; i++)
            {
                for(int j = i + 1;j< cliente.Count;j++)
                {
                    if(cliente[i].Edad > cliente[j].Edad)
                    {
                        aux = cliente[i];
                        cliente[i] = cliente[j];
                        cliente[j] = aux;
                    }
                      
                }
            }
        }

        public static void OrdenarEdadMayor(List<Cliente> cliente)
        {
            Cliente aux;

            for (int i = 0; i < cliente.Count; i++)
            {
                for (int j = i + 1; j < cliente.Count; j++)
                {
                    if (cliente[i].Edad < cliente[j].Edad)
                    {
                        aux = cliente[i];
                        cliente[i] = cliente[j];
                        cliente[j] = aux;
                    }

                }
            }
        }

        //dadawdaw
        public static string GeneraSiNoRandom()
        {
            string retorno;
            Random random = new Random();
            int entero = random.Next(0,100);
            if(entero % 2 == 0)
            {
                retorno = "si";
            }
            else
            {
                retorno = "no";
            }
            return retorno;
        }

        public static Cliente BuscarClientePorDni(int dni)
        {
            foreach (Cliente item in Sistema.Clientes)
            {
                if(item.Dni == dni)
                {
                    return item;  
                }

            }
            return null;
        }

        public static double CalcularRecaudacion()
        {
            Random random = new Random();

            return (random.Next(800, 1200) * Sistema.Viajes.Count);
        }
    }
}
