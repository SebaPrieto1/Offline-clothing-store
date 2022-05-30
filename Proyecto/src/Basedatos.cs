using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;


namespace ProyectoFInal
{
    class Basedatos
    {
        //Listas donde se almacenan los datos de la tienda
        //La idea del proyecto es desplegar los datos de las listas en LisBoxes o DataGridViews
        //Al abrir el proyecto desde otra pc se debe cambiar la direccion de carga de archivos desde la siguinte variable
        private static string path = Directory.GetCurrentDirectory();
     

        
        private static BindingList<Tarjetas> listaTarjetas = new BindingList<Tarjetas>();
        private static BindingList<Producto> productitos = new BindingList<Producto>();
        private static List<Clientes1> clientitos = new List<Clientes1>();
        internal static BindingList<Tarjetas> ListaTarjetas { get => listaTarjetas; set => listaTarjetas = value; }
        internal static BindingList<Producto> Productitos { get => productitos; } 
        internal static List<Clientes1> Clientitos { get => clientitos; set => clientitos = value; }

        //Creacion de producto y guardado en la lista de productos
        public static void CrearProducto(string Ctipo, string Cmarca, int Ctalle, double Cprecio)
        {
            Producto productogen = new Producto(Ctipo, Cmarca, Ctalle, Cprecio);
            Productitos.Add(productogen);
        }

        //Creacion de usuario y guardado en la lista de usuarios
        public static void CrearUsuario(string Nombre, string Apellido, int DNI)
        {
            Clientes1 ClienteGen = new Clientes1(Nombre, Apellido, DNI);
            Clientitos.Add(ClienteGen);
        }

        //Creacion de tarjeta y guardado en la lista de tarjetas
        public static void CrearTarjeta(string Nombre, string Banco)
        {
            Tarjetas tarjetagen = new Tarjetas(Nombre, Banco);
            ListaTarjetas.Add(tarjetagen);
        }


        //interacciones con tarjeta (Podrian haberse omitido y utilizar directamente de las listas)
        public static void BorrarTarjeta(int index)
        {
            ListaTarjetas.RemoveAt(index);
        }
        public static void AñadirPagoTarjeta(int index, int cuotas, int interes, string promocion)
        {

            ListaTarjetas[index].SetFormaPago(cuotas, interes, promocion);

        }

        public static void EliminarPagoTarjeta(int indextarjeta, int indexpago)
        {

            ListaTarjetas[indextarjeta].BorrarFormaPago(indexpago);

        }
        public static void EliminarPagoSTarjeta(int indextarjeta)
        {

            ListaTarjetas[indextarjeta].BorrarPagos();

        }





        /***************************************Guardado de archivos************************************/



        static public void ArchivarProductos()
        {
            try
            {
                
                using (TextWriter sw = new StreamWriter(path + @"\Productos.txt"))
                {
                    foreach (var producto in Productitos)
                    {
                        sw.WriteLine(producto.Tipo + ";" + producto.Marca + ";" + producto.Talla + ";" + producto.Precio + ";" + producto.Descuento + ";" + producto.PrecioOriginal);

                    }
                }
            }
            catch (Exception e) { }
        }

        static public void ArchivarTarjetas()
        {
            try
            {
                using (TextWriter sw = new StreamWriter(path + @"\Tarjetas.txt"))
                {
                    foreach (var tarjeta in ListaTarjetas)
                    {
                        sw.WriteLine(tarjeta.Nombre + ";" + tarjeta.Banco + ";" + tarjeta.TotGastado);

                    }
                }
            }
            catch (Exception e) { }
        }

        static public void ArchivarClientes()
        {
            try
            {
                using (TextWriter sw = new StreamWriter(path + @"\Clientes.txt"))
                {
                    foreach (var cliente in Clientitos)
                    {
                        sw.WriteLine(cliente.Nombre + ";" + cliente.Apellido + ";" + cliente.DNI+";"+cliente.TotGastado);

                    }
                }
            }
            catch (Exception e) { }
        }


        /***************************************Carga de archivos***************************************/


        static public void CargarProductos()
        {

            try
            {

                //Carga de productos
                using (TextReader tw = new StreamReader(path + @"\Productos.txt"))
                {
                    string line;
                    string car = ";";
                    while ((line = tw.ReadLine()) != null)
                    {
                        string[] split = line.Split(car);
                        Producto prodGen = new Producto(split[0], split[1], int.Parse(split[2]), double.Parse(split[3]), split[4], double.Parse(split[5]));
                        productitos.Add(prodGen);
                    }

                }


                //Carga de tarjetas
                using (TextReader tw = new StreamReader(path + @"\Tarjetas.txt"))
                {
                    string line;
                    string car = ";";
                    while ((line = tw.ReadLine()) != null)
                    {
                        string[] split = line.Split(car);
                        Tarjetas tarGen = new Tarjetas(split[0], split[1], double.Parse(split[2]));
                        ListaTarjetas.Add(tarGen);
                    }

                }


                //Carga de clientes

                using (TextReader tw = new StreamReader(path + @"\Clientes.txt"))
                {
                    string line;
                    string car = ";";
                    while ((line = tw.ReadLine()) != null)
                    {
                        string[] split = line.Split(car);
                        Clientes1 clientGen = new Clientes1(split[0], split[1], int.Parse(split[2]), double.Parse(split[3]));
                        Clientitos.Add(clientGen);
                    }

                }


            }
            catch (Exception e)
            {

            }

        }

    }
}
