using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFInal
{
    public partial class ModProductos : Form
    {

        public ModProductos()
        {
            InitializeComponent();
            panelnuevoproducto.Size = new Size(526,174);
            panelnuevoproducto.Location = new Point(160, 79);
        }


        private void ModProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = Basedatos.Productitos;
            if (Basedatos.Productitos.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnagregardescuento.Enabled = false;
                btnquitdescuento.Enabled = false;
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           panelnuevoproducto.Visible = true;
           paneldescuento.Visible = false;
           dgvProductos.DataSource = Basedatos.Productitos;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvProductos.CurrentCell.RowIndex != -1)
            {
                int index = dgvProductos.CurrentCell.RowIndex;
                Basedatos.Productitos.RemoveAt(index);
            }
            if (Basedatos.Productitos.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnagregardescuento.Enabled = false;
                btnquitdescuento.Enabled = false;
            }
        }

        private void btnpromocionar_Click(object sender, EventArgs e)
        {
            panelnuevoproducto.Visible = false;
            paneldescuento.Visible = true;

        }

        //Boton Volver
        private void button1_Click(object sender, EventArgs e)
        {
            Basedatos.ArchivarProductos();
            this.Close();
        }


        private void btnnuevoproducto_Click(object sender, EventArgs e)
        {
            try
            {
                Basedatos.CrearProducto(txtTipo.Text, txtMarca.Text, int.Parse(txtTalle.Text), double.Parse(txtPrecio.Text));
                btnagregardescuento.Enabled = true;
                btnEliminar.Enabled = true;
                btnquitdescuento.Enabled = true;

            }
            catch(Exception ex) {MessageBox.Show("Producto invalido");}
            txtMarca.Clear();
            txtPrecio.Clear();
            txtTalle.Clear();
            txtTipo.Clear();
        }

        private void btnagregardescuento_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentCell.RowIndex != -1)
                {
                    int index = dgvProductos.CurrentCell.RowIndex;
                    Basedatos.Productitos[index].SetDiscount(int.Parse(txtdescuento.Text));
                }
            }
            catch(Exception ex) { MessageBox.Show("Dato invalido, debe ingresar un numero entero"); }
        }

        private void btnquitdescuento_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProductos.CurrentCell.RowIndex;
                Basedatos.Productitos[index].QuitarDescuento();
            }
            catch (Exception ex) { MessageBox.Show("No se pudo eliminar el producto"); }
        }


        //Codigo agregado para mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
