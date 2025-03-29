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
    public partial class InicioSesion: Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            PaginaPrincipal PaginaPrincipal = new PaginaPrincipal();
            string nombre = TxtNombre.Text;
            string numeroDocumento = TxtDocumento.Text;

            var encontrar = Empresa.Usuarios.FirstOrDefault(x => x.Nombre == nombre && x.NumeroIdentidad == numeroDocumento);

            if (encontrar != null)
            {
                MessageBox.Show("El inicio de sesión ha sido exitoso", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PaginaPrincipal.Show();
                this.Hide();
            }

            else { MessageBox.Show("El nombre o el número de documento no coinciden", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
