using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Camisa
    {
        Operaciones myOperation = new Operaciones(0, 0, 0, false);

        public void logicaNegocio( )
        {
            myOperation.setTotal(1000);
            myOperation.setDescuento(1000);
            myOperation.setContador(1);
            if (myOperation.getTotal() == 3000)
            {
                myOperation.calcularDescuento(1000.0 * 0.15);
            }
            if (myOperation.getTotal() == 6000)
            {
                myOperation.calcularDescuento(1000.0 * 0.20);
            }

        }

        public void descontarCamisas()
        {
            myOperation.setTotal(-1000);
        }

        public void mostrarDescuentos()
        {
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
        }

        public void salida()
        {
            
            char opcionSalida;
            Console.WriteLine("Esta seguro que desea salir? S/N");
            opcionSalida = Convert.ToChar(Console.ReadLine());
            if (opcionSalida == 'S')
            {
                myOperation.setBool(true);
            }
            else
            {
                myOperation.setBool(false);
            }
        }

    }
}
