using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ProyectoFInal
{
    class Tarjetas
    {
        string nombre;

        string banco;

        double TotGastado1;

        BindingList<string> FormasPago = new BindingList<string>();


        public string Nombre { get => nombre; }
        public string Banco { get => banco; }
        public double TotGastado { get => TotGastado1; set => TotGastado1 = value; }
        public BindingList<string> FormasPago1 { get => FormasPago; set => FormasPago = value; }
        public int Promos { get => promos; set => promos = value; }

        int promos=0;

        //Constructor para tarjeta nueva
        public Tarjetas(string nombre, string banco)
        {
            this.nombre = nombre;
            this.banco = banco;
            FormasPago.Add("1 Cuota, sin interes");
        }
        //Constructor para cargar tarjeta de archivo
        public Tarjetas(string nombre, string banco, double gastos)
        {
            this.nombre = nombre;
            this.banco = banco;
            TotGastado1 = gastos;
            FormasPago.Add("1 Cuota, sin interes");
        }



        public void SetFormaPago(int cuotas, int interes, string promocion)
        {
            if (promocion == "No")
            {
                FormasPago.Add(+cuotas + " Cuotas, con " + interes + "% de interes");
            }
            else
            {
                FormasPago.Add("Promocion de "+cuotas + " Cuotas, sin interes*");
                Promos++;
            }


        }

        public void BorrarFormaPago(int index)
        {
            string car = ",";
            string[] split = FormasPago[index].Split(car);
            foreach (string pago in split)
            {
                if (pago == " sin interes*") Promos--;
            }
            FormasPago.RemoveAt(index);
        }
        public void BorrarPagos()
        {
            FormasPago.Clear();
            Promos = 0;
        }

        public void ActGastos(double gasto)
        {
            TotGastado1 += gasto;
        }









    }
}
