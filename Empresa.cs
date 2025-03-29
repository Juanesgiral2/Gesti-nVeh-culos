using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    partial class Empresa
    {
        //Atributos
        public Usuario Usuario { get; private set; }
        public Vehiculo Vehiculo { get; private set; }
        public static List<Usuario> Usuarios { get; private set; } = new List<Usuario> {

                new Usuario("Juan Esteban","Giraldo Aguirre","1035414917","Administrador"),
                new Usuario("Juan", "Pérez", "1234567890", "Cliente"),
                new Usuario("Ana", "Gómez", "0987654321", "Cliente"),
                new Usuario("Carlos", "Rodríguez", "1122334455", "Cliente"),
                new Usuario("Laura", "Martínez", "6677889900", "Cliente")
        };

        public static List<Vehiculo> Vehiculos { get; private set; } = new List<Vehiculo>
        {
                new Moto("Yamaha", "CB", "2024", "Mediano", "160cc"),
                new Moto("KTM", "Duke 390", "2023", "Naked", "390cc"),
                new Moto("BMW", "G 310 R", "2024", "Naked", "310cc"),
                new Moto("Harley-Davidson", "Sportster", "2023", "Cruiser", "1200cc"),
                new Carro("Mazda", "CX-5", "2023", "5", "Gasolina"),
                new Carro("Volkswagen", "Golf", "2022", "4", "Diesel"),
                new Carro("Nissan", "Altima", "2024", "4", "Híbrido"),
                new Carro("BMW", "Series 3", "2023", "4", "Eléctrico")
        };
        
    }
}
