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
    public partial class PaginaPrincipal: Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Hide();
        }
    }
}
