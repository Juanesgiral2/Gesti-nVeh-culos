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
            //Código para centrar el label1
            label1.AutoSize = false;
            label1.Width = 1200;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            //Código para asignar los valores de los objetos de la lista Vehiculos en el datagridview
            foreach (Vehiculo vehiculo in Empresa.Vehiculos) 
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["Marca"].Value = vehiculo.Marca;
                dataGridView1.Rows[index].Cells["Modelo"].Value = vehiculo.Modelo;
                dataGridView1.Rows[index].Cells["Año"].Value = vehiculo.Año;
                dataGridView1.Rows[index].Cells["PrecioDia"].Value = vehiculo.PrecioDia;
                dataGridView1.Rows[index].Cells["Placa"].Value = vehiculo.Placa;
                dataGridView1.Rows[index].Cells["Estado"].Value = vehiculo.Estado;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void alquilerMotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlquilerMotos motos = new AlquilerMotos();
            motos.Show();
            this.Hide();
        }

        private void alquilerCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
