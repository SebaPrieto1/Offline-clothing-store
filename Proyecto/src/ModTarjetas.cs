using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFInal
{
    public partial class ModTarjetas : Form
    {
        public ModTarjetas()
        {
            InitializeComponent();
            foreach (var Tarjeta in Basedatos.ListaTarjetas)
            {
                listBox1.Items.Add(Tarjeta.Nombre+" "+Tarjeta.Banco);
            }

        }


        private void btnvolver1_Click(object sender, EventArgs e)
        {
            Basedatos.ArchivarTarjetas();
            this.Close();
        }

        private void btnagregartarjeta_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            btnEliminar.Visible = false;
            btnFormasPago.Visible = false;
            panel3.Visible = false;
            btnEliminarPago.Visible = false;
            btnFormasPago.Text = "Añadir forma de pago";
            lblintro.Visible = false;
            picintro.Visible = false;

        }

        private void btnlistartarje_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = true;
            btnEliminar.Visible = true;
            btnFormasPago.Visible = true;
            panel2.Visible = false;
            btnEliminarPago.Visible = true;
            lblintro.Visible = false;
            picintro.Visible = false;
        }

        private void btnaddtarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txttipotarjeta.Text != "") && (txtbanco.Text != ""))
                {
                    Basedatos.CrearTarjeta(txttipotarjeta.Text, txtbanco.Text);
                    RefreshLista();
                    txtbanco.Clear();
                    txttipotarjeta.Clear();
                    MessageBox.Show("Tarjeta añadida a la base de datos");
                }
                else MessageBox.Show("Datos invalidos");
            }
            catch (Exception ex) {; }
        }
        //Eliminar tarjeta de la base de datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int index1 = listBox1.SelectedIndex;
                    Basedatos.EliminarPagoSTarjeta(index1);
                    Basedatos.BorrarTarjeta(index1);
                    listBox1.Items.RemoveAt(index1);
                }
                else MessageBox.Show("Debe seleccionar una tarjeta de la lista");
            }
            catch(Exception ex) {; }
        }

        //Mostrar info de pagos de la tarjeta seleccionada
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int index2 = listBox1.SelectedIndex;
                listBox2.DataSource = Basedatos.ListaTarjetas[index2].FormasPago1;
            }
            catch (Exception ex)
            {
    
            }
        }
        //Desplegar menu de pagos
        private void btnFormasPago_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (btnFormasPago.Text != "Ocultar")
                {
                    panel3.Visible = true;
                    btnFormasPago.Text = "Ocultar";
                }
                else
                {
                    panel3.Visible = false;
                    btnFormasPago.Text = "Añadir forma de pago";
                }
            }
            else MessageBox.Show("Debe seleccionar una tarjeta de la lista");
        }
        //Añadir efectivamente un pago
        private void btnaniaforpago_Click(object sender, EventArgs e)
        {
           
            if ((listBox1.SelectedIndex != -1)&&(listBox1.Items.Count!=0))
            {
                try
                {
                    int index3 = listBox1.SelectedIndex;
                    string promo = "No";
                    if (int.Parse(txtaddintereses.Text) == 0)
                    {
                        promo = "Si";
                    }
                    Basedatos.AñadirPagoTarjeta(index3, int.Parse(txtaddcuotas.Text), int.Parse(txtaddintereses.Text), promo);
                    RefreshLista();
                }
                catch(Exception ex) { MessageBox.Show("Datos invalidos"); }
            }
            else MessageBox.Show("Debe seleccionar una tarjeta de la lista");
            txtaddcuotas.Clear();
            txtaddintereses.Clear();
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedIndex != -1) && (listBox2.SelectedIndex != -1))
            {
                int indextarjeta = listBox1.SelectedIndex;
                int indexpago = listBox2.SelectedIndex;
                Basedatos.EliminarPagoTarjeta(indextarjeta, indexpago);
                RefreshLista();
            }
            else MessageBox.Show("Debe seleccionar una tarjeta de la lista y un medio de pago");

        }


        private void RefreshLista()
        {
            listBox1.Items.Clear();
            foreach (var Tarjeta in Basedatos.ListaTarjetas)
            {
                if (Tarjeta.Promos == 0)
                {
                    listBox1.Items.Add("Tarjeta " + Tarjeta.Nombre + " Banco " + Tarjeta.Banco);
                }
                else
                {
                    listBox1.Items.Add("Tarjeta " + Tarjeta.Nombre + " Banco " + Tarjeta.Banco + " con " + Tarjeta.Promos + " promo/s");
                }

            }


        }


    }
}
