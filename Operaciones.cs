using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Operaciones
    {
        private double total;
        private double totalDescuento;

        public Operaciones(double total, double totalDescuento)
        {
            this.total = total;
            this.totalDescuento = totalDescuento;
        }


        public void setTotal(double totalCompra)
        {
            this.total += totalCompra;
        }

        public double getTotal()
        {
            return this.total;
        }

        public void setDescuento(double descuentoCompra)
        {
            this.totalDescuento += descuentoCompra;
        }
        public double getDescuento()
        {
            return this.totalDescuento;
        }

        public void calcularDescuento(double descuento)
        {
            this.totalDescuento -= descuento;
        }

    }
}
