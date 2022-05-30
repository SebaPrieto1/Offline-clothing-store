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
    public partial class ModCompras : Form
    {

        bool clienteidentificado = false;
        int idcliente;
        Orden OrdenGen = new Orden();
        
        public ModCompras()
        {
            InitializeComponent();
            dgvproductos.DataSource = Basedatos.Productitos;
            dgvcarrito.DataSource = OrdenGen.OrdenCarro;
            panelIdentificarse.Size = new Size(502, 528);
            panelIdentificarse.Location = new Point(170, 70);
            panelPagos.Size = new Size(502, 445);
            panelPagos.Location  = new Point(172, 74);
            piccarrito.Size = new Size(416, 446);
            piccarrito.Location = new Point(227, 110);
            try
            {
                foreach (var Tarjeta in Basedatos.ListaTarjetas)
                {
                    listBox1.Items.Add(Tarjeta.Nombre + " " + Tarjeta.Banco);
                }
            }
            catch { }
            if (Basedatos.Productitos.Count == 0)
            {
                btnagregar.Enabled = false;
                btnquitar.Enabled = false;
                MessageBox.Show("Actualmente no hay productos en stock");
            }

        }
        //Actualizo los archivos antes de cerrar el form
        private void btnvolver_Click(object sender, EventArgs e)
        {
            Basedatos.ArchivarClientes();
            Basedatos.ArchivarTarjetas();
            this.Close();
        }

 
        private void mostrarregistro()
        {
            lvlapellido.Show();
            lvldni.Show();
            lvlnombre.Show();
            txtsaveid.Show();
            txtsavename.Show();
            txtsavesurname.Show();
            btnregistraruser.Show();

        }
        private void Ocultarrgistro()
        {
            lvlapellido.Hide();
            lvldni.Hide();
            lvlnombre.Hide();
            txtsaveid.Hide();
            txtsavename.Hide();
            txtsavesurname.Hide();
            btnregistraruser.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            panelIdentificarse.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panelPagos.Visible = false;
            piccarrito.Visible = false;


        }

        private void lblusuarionuevo_Click(object sender, EventArgs e)
        {
            mostrarregistro();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            panelIdentificarse.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panelPagos.Visible = false;
            piccarrito.Visible = false;

        }

        //En caso de no existir, se agrega el cliente a la lista de clientes
        private void btnregistraruser_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                if (Basedatos.Clientitos.Count != 0)
                {
                    foreach (var cliente in Basedatos.Clientitos)
                    {
                        if (cliente.DNI == int.Parse(txtsaveid.Text))
                        {
                            MessageBox.Show("Ya existe el cliente, porfavor Identifiquese");
                            existe = true;
                        }
                    }
                }
                if (!existe)
                {
                    Basedatos.CrearUsuario(txtsavename.Text, txtsavesurname.Text, int.Parse(txtsaveid.Text));
                    MessageBox.Show("Cliente creado exitosamente");
                }
                Ocultarrgistro();

            }
            catch(Exception ex) { MessageBox.Show("Datos invalidos"); }
            txtsaveid.Clear();
            txtsavename.Clear();
            txtsavesurname.Clear();
        }

        //Reviso si el usuario se encuentra en los registros
        private void btnbuscardni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Basedatos.Clientitos.Count != 0)
                {

                    foreach (var cliente in Basedatos.Clientitos)
                    {
                        if (cliente.DNI == int.Parse(txtgetid.Text))
                        {
                            clienteidentificado = true;
                            pictureBoxLupa.Visible = false;
                            pictureBoxUser.Visible = true;
                            lblUsuarioIdentificado.Text = "" + cliente.NombreYape();
                            MessageBox.Show("Bienvenido " + cliente.NombreYape());
                            idcliente = cliente.DNI;
                            btnbuscardni.Enabled = false;
                        }

                    }
                }
                if (!clienteidentificado) { MessageBox.Show("No se encuentra en la base de datos, por favor registrese"); }
                txtgetid.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Ingrese un DNI valido"); }
        }
        //Agregar producto al carro/orden
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (dgvproductos.CurrentCell.RowIndex != -1)
            {
                int index1 = dgvproductos.CurrentCell.RowIndex;
                OrdenGen.OrdenCarro.Add(Basedatos.Productitos[index1]);
                index1 = 0;
            }
            foreach(var producto in OrdenGen.OrdenCarro)
            {
               OrdenGen.Preciototal += producto.Precio;

            }
            lblprecio.Text = "" + OrdenGen.Preciototal + " $";
            OrdenGen.Preciototal = 0;
            btnquitar.Enabled = true;
        }
        //Quitar productos del carro/orden
        private void btnquitar_Click(object sender, EventArgs e)
        {

                if ((dgvproductos.CurrentCell.RowIndex != -1))
                {
                    try
                    {
                        OrdenGen.OrdenCarro.RemoveAt(dgvcarrito.CurrentCell.RowIndex);
                    }
                    catch (Exception ex) { MessageBox.Show("No hay ningun producto en la orden"); }
                }
                foreach (var producto in OrdenGen.OrdenCarro)
                {
                    OrdenGen.Preciototal += producto.Precio;

                }
                lblprecio.Text = "" + OrdenGen.Preciototal + " $";
                OrdenGen.Preciototal = 0;
            if (OrdenGen.OrdenCarro.Count == 0)
            {
                btnquitar.Enabled = false;
            }

        }

        //Boton de pago final
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedIndex != -1) && (listBox2.SelectedIndex != -1))
            {
                MessageBox.Show("Gracias por su compra!");
                foreach (var producto in OrdenGen.OrdenCarro)
                {
                    OrdenGen.Preciototal += producto.Precio;

                }
                AñadirPlata(OrdenGen.Preciototal);
                AñadirGastosTarjeta(OrdenGen.Preciototal);
                OrdenGen.OrdenCarro.Clear();
                panel3.Visible = false;
                panelPagos.Visible = false;
                panel2.Visible = false;
                piccarrito.Visible = true;
                OrdenGen.Preciototal = 0;
                lblprecio.Text ="0 $";
            }
            else MessageBox.Show("Seleccione una tarjeta y un medio de pago!");
        }

        //Renuevo la informacion de la tabla de formas de pago
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                listBox2.DataSource = Basedatos.ListaTarjetas[index].FormasPago1;
            }
            catch (Exception ex)
            {

            }
        }
        //En caso de estar identificado y de haber productos en el carro se procede a realizar la compra
        private void btnrealizarcompra_Click(object sender, EventArgs e)
        {
            if ((clienteidentificado) && (OrdenGen.OrdenCarro.Count != 0))
            {
                panel2.Visible = false;
                panelIdentificarse.Visible = false;
                panelPagos.Visible = true;
            }
            else if (clienteidentificado) MessageBox.Show("Orden vacia, no hay nada que comprar");
            else MessageBox.Show("Debe identificarse para realizar una compra");
        }

        //Actualizo gastos del cliente
        private void AñadirPlata(double Gastos)
        {
            if (Basedatos.Clientitos.Count != 0)
            {
                foreach (var cliente in Basedatos.Clientitos)
                {
                    if (cliente.DNI == idcliente)
                    {
                        cliente.AddGastos(Gastos);
                    }

                }
            }
        }
        //Actualizo gastos de la tarjeta
        private void AñadirGastosTarjeta(double Gastos)
        {

            if(listBox1.SelectedIndex != -1)
            {
                Basedatos.ListaTarjetas[listBox1.SelectedIndex].ActGastos(Gastos);

            }

        }

    }


}
