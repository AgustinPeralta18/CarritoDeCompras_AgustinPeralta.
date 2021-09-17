using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class MenuOpciones
    {
        Operaciones myOperation = new Operaciones(0, 0, 0, false);
        Camisa myCamisa = new Camisa();
        Menu myMenu = new Menu();
        public void menu()
        {
            int opcion;
            do
            {
                myMenu.menu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        myCamisa.logicaNegocio();
                        break;
                    case 2:
                        myCamisa.descontarCamisas();
                        break;

                    case 3:
                        myCamisa.salida();
                        break;
                    default:
                        break;
                        Console.WriteLine("Si compra entre 3 a 5 remeras 15% de descuento!");
                        Console.WriteLine("Si compra mas de 6 remeras 20% de descuento!");
                }

            } while (opcion != 3 && myOperation.getSalida() != true);
        }
          
}
