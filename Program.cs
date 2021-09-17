using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que calcule el total a pagar por la compra de camisas en un shopping
            online. El programa deberá mostrar todos los datos del carrito de compras, así como también
            deberá mostrar el menú de opciones para poder agregar o quitar camisas del carrito.
             */


            MenuOpciones myMenu = new MenuOpciones();

            myMenu.menu();
            Console.ReadKey();
        }
    }
}
