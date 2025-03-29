using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVehiculos
{
    public partial class Registro: Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellidos = TxtApellidos.Text;
            string numeroIdentificacion = TxtNumeroID.Text;
            string tipoUsuario = CbTipoUsuario.Text;

            var encontrar = Empresa.Usuarios.FirstOrDefault(x => x.NumeroIdentidad == numeroIdentificacion);

            if (encontrar == null)
            {
                Usuario Usuario = new Usuario(nombre, apellidos, numeroIdentificacion, tipoUsuario);
                Empresa.Usuarios.Add(Usuario);
                MessageBox.Show("Usuario registrado con éxito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicioSesion inicioSesion = new InicioSesion();
                inicioSesion.Show();
                this.Hide();
            }

            else 
            {
                MessageBox.Show("Este usuario ya existe en nuestros registros", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
