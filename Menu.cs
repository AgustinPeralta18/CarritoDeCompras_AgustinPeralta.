using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Menu
    {
        Operaciones myOperation = new Operaciones(0, 0);

        public void menu()
        {
            int opcion;
            bool salida = false;

            do
            {
                Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("1- Añadir camisa al carro de compras");
                Console.WriteLine("2- Eliminar camisa del carro de compras");
                Console.WriteLine("3- Salir");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("         -Cantidad de camisas en el carro de compras:");
                Console.WriteLine("         -Precio unitario: 1000");
                Console.WriteLine("         -Precio total sin descuento: " + myOperation.getTotal());
                if (myOperation.getTotal() >= 3000 && myOperation.getTotal() <= 5000)
                {
                    Console.WriteLine("         -Tipo de descuento aplicado: % 15");
                    Console.WriteLine("         -Precio final con descuento: " + myOperation.getDescuento());
                }
                if (myOperation.getTotal() >= 6000)
                {
                    Console.WriteLine("         -Tipo de descuento aplicado: % 20");
                    Console.WriteLine("         -Precio final con descuento: " + myOperation.getDescuento());
                }
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Ingrese una opcion del menu: ");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        myOperation.setTotal(1000);
                        myOperation.setDescuento(1000);
                        if (myOperation.getTotal() == 3000)
                        {
                            myOperation.calcularDescuento(1000.0 * 0.15);
                        }
                        if (myOperation.getTotal() == 6000)
                        {
                            myOperation.calcularDescuento(1000.0 * 0.20);
                        }

                        break;
                    case 2:
                        myOperation.setTotal(-1000);
                        break;

                    case 3:
                        char opcionSalida;
                        Console.WriteLine("Esta seguro que desea salir? S/N");
                        opcionSalida = Convert.ToChar(Console.ReadLine());
                        if (opcionSalida == 'S')
                        {
                            salida = true;
                        }
                        else
                        {
                            salida = false;
                        }
                        break;
                    default:
                        break;
                    Console.WriteLine("Si compra entre 3 a 5 remeras 15% de descuento!");
                    Console.WriteLine("Si compra mas de 6 remeras 20% de descuento!");
                }


                

            } while (opcion != 3 && salida != true);
            
            

            


        }
    }
}
