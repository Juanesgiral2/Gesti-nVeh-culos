using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    class Usuario
    {
        //Atributos
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string NumeroIdentidad { get; private set; }
        public string TipoUsuario { get; private set; }


        //Constructor
        public Usuario(string nombre, string apellido, string documento, string usuario) 
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroIdentidad = documento;
            TipoUsuario = usuario;
        }
    }

}
