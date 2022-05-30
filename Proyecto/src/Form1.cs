using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFInal
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
            Basedatos.CargarProductos();
        }


        private void btnadmin_Click(object sender, EventArgs e)
        {
            ModAdmin FormaAdmin = new ModAdmin();
            FormaAdmin.ShowDialog();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            ModProductos FormaProductos = new ModProductos();
            FormaProductos.ShowDialog();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            ModCompras FormaCompras = new ModCompras();
            FormaCompras.ShowDialog();
        }

        private void btntarjetas_Click(object sender, EventArgs e)
        {
            ModTarjetas FormaTarjetas = new ModTarjetas();
            FormaTarjetas.ShowDialog();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
