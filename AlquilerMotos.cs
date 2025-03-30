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
    public partial class AlquilerMotos: Form
    {
        public AlquilerMotos()
        {
            InitializeComponent();
            List<string> Placas = new List<string>();
            foreach (var vehiculo in Empresa.Vehiculos) {
                if (vehiculo is Moto) 
                {
                    Placas.Add(vehiculo.Placa);
                }
            }
            CbPlaca.Text = "";
            CbPlaca.DataSource = Placas;
        }

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal principal = new PaginaPrincipal();
            principal.Show();
            this.Hide();
        }

        private void AlquilerMotos_Load(object sender, EventArgs e)
        {

        }
        private void CbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var encontrar = Empresa.Vehiculos.FirstOrDefault(x => x.Placa == CbPlaca.Text);

            if (encontrar != null)
            {
                TxtMarca.Text = encontrar.Marca;
                TxtModelo.Text = encontrar.Modelo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alquiler confirmado");
        }
    }
}
