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
        public static List<Usuario> Usuarios { get; private set; } = new List<Usuario> {

                new Usuario("Juan Esteban","Giraldo Aguirre","1035414917","Administrador"),
                new Usuario("Juan", "Pérez", "1234567890", "Cliente"),
                new Usuario("Ana", "Gómez", "0987654321", "Cliente"),
                new Usuario("Carlos", "Rodríguez", "1122334455", "Cliente"),
                new Usuario("Laura", "Martínez", "6677889900", "Cliente")
        }; 

        
    }
}
