using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    class Vehiculo
    {
        //Atributos
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string Año { get; protected set; }
        public string Estado { get; protected set; }
        public virtual int PrecioDia { get; protected set; }

        //Constructor
        public Vehiculo(string marca, string modelo, string año) 
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Estado = "Para alquilar";
        }

        //Método
        public int CalcularAlquiler(int dias)
        {
            return PrecioDia * dias;
        }

    }

    class Moto : Vehiculo
    {
        //Atributo
        public string TipoManillar { get; private set; }
        public string Cilindraje { get; private set; }
        public override int PrecioDia { get { return 25000; } }

        //Constructor
        public Moto(string marca, string modelo, string año, string manillar, string cilindraje) : base (marca,modelo,año)
        {
            TipoManillar = manillar;
            Cilindraje = cilindraje;
        }
    }

    class Carro : Vehiculo
    {
        //Atributos
        public string NumeroPuertas { get; private set; }
        public string TipoCombustible { get; private set; }
        public override int PrecioDia { get { return 50000; } }

        //Constructor
        public Carro(string marca, string modelo, string año, string puertas, string combustible):base(marca,modelo,año) 
        {
            NumeroPuertas = puertas;
            TipoCombustible = combustible;
        }
    }
}
