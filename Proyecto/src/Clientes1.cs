using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFInal
{
    class Clientes1
    {
        string nombre;
        string apellido;
        int dni;
        double totGastado = 0;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int DNI { get => dni; }
        public double TotGastado { get => totGastado; }

        public Clientes1 (string Nombre, string Apellido, int DNI)
        {
            nombre = Nombre;
            apellido = Apellido;
            dni = DNI;

        }
        public Clientes1(string Nombre, string Apellido, int DNI, double Gastos)
        {
            nombre = Nombre;
            apellido = Apellido;
            dni = DNI;
            totGastado = Gastos;

        }


        public void AddGastos(double plata)
        {

            totGastado += plata;

        }
        public string NombreYape()
        {
            return nombre+" "+apellido;
        }




    }
}
