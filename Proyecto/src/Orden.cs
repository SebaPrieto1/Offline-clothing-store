using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ProyectoFInal
{
    class Orden
    {

        public BindingList<Producto> OrdenCarro = new BindingList<Producto>();

        double preciototal;

        public double Preciototal { get => preciototal; set => preciototal = value; }

        public double GetPrecio()
        {
            return preciototal;
        }


    }
}
