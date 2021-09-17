using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Menu
    {
        Operaciones myOperation = new Operaciones(0, 0, 0, false);
        Camisa myCamisa = new Camisa();
        public void menu()
        {
            
            Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("MENU PRINCIPAL:");
            Console.WriteLine("1- Añadir camisa al carro de compras");
            Console.WriteLine("2- Eliminar camisa del carro de compras");
            Console.WriteLine("3- Salir");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("         -Cantidad de camisas en el carro de compras:" + myOperation.getContador());
            Console.WriteLine("         -Precio unitario: 1000");
            Console.WriteLine("         -Precio total sin descuento: " + myOperation.getTotal());
            myCamisa.mostrarDescuentos();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Ingrese una opcion del menu: ");
        }
    }
}
