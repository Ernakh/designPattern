using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Prototype
{
    public abstract class CarroPrototype
    {
        protected double valorCompra;

        public abstract string exibirInfo();

        public abstract CarroPrototype clonar();

        public double getValorCompra()
        {
            return valorCompra;
        }
        public void setValorCompra(double valorCompra)
        {
            this.valorCompra = valorCompra;
        }
    }
}
