using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFInal
{
    class Producto
    {
        private string tipo;
        private string marca;
        private int talla;
        private double precio;
        private string descuento;

        public string Tipo { get => tipo;  }
        public string Marca { get => marca; }
        public int Talla { get => talla;  }
        public double Precio { get => precio; }
        public string Descuento { get => descuento; }
        public double PrecioOriginal { get => registro; }

        private double registro;

        //Constructor utilizado para crear producto nuevo
        public Producto(string tipe, string mark, int size, double price)
        {
            tipo = tipe;
            marca = mark;
            talla = size;
            precio = price;
            descuento = "Sin promocion";
            registro = precio;
        }
        //Constructor utilizado para cargar datos de usuario de un archivo
        public Producto(string tipe, string mark, int size, double price,string discount,double register)
        {
            tipo = tipe;
            marca = mark;
            talla = size;
            precio = price;
            descuento = discount;
            registro = register;
        }

        public void SetDiscount(int descuento)
        {   
            precio = precio * (1 - descuento/100.0);
            this.descuento = descuento + "% Off";   
            
        }
        public void QuitarDescuento()
        {
            this.descuento = "Sin promocion";
            precio = registro;
        }
        
    }
}
