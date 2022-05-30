using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFInal
{
    public partial class ModAdmin : Form
    {
        public ModAdmin()
        {
            InitializeComponent();
        }

        private void ModAdmin_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = Basedatos.Clientitos;
            dgvTarjetas.DataSource = Basedatos.ListaTarjetas;
            lblGastoTotTienda.Text = ObtenerGastosTotales() + " $";
            lblTotUsers.Text = Basedatos.Clientitos.Count + "";
            lblTotTarjetas.Text = Basedatos.ListaTarjetas.Count + "";
        }

        private double ObtenerGastosTotales()
        {
            double variable = 0;
            foreach (var cliente in Basedatos.Clientitos)
            {
                variable += cliente.TotGastado;

            }

            return variable;
        }





    }
}
