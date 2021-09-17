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
        private int contador;
        private bool salida;

        public Operaciones(double total, double totalDescuento,int contador, bool salida)
        {
            this.total = total;
            this.totalDescuento = totalDescuento;
            this.contador = contador;
            this.salida = salida;
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

        public void setContador(int contador)
        {
            this.contador += contador;
        }

        public int getContador()
        {
            return this.contador;
        }
        public void setBool(bool salida)
        {
            this.salida = salida;
        }

        public bool getSalida()
        {
            return this.salida;
        }

        public void calcularDescuento(double descuento)
        {
            this.totalDescuento -= descuento;
        }


        
    }
}
