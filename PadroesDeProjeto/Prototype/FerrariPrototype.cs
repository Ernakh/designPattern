using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Prototype
{
    public class FerrariPrototype : CarroPrototype
    {
        public FerrariPrototype()
        {
            valorCompra = 0;
        }

        private FerrariPrototype(FerrariPrototype ferrariPrototype)
        {
            this.valorCompra = ferrariPrototype.getValorCompra();//clono os valores dos atributos
        }

        public override CarroPrototype clonar()
        {
            return new FerrariPrototype(this);
        }

        public override string exibirInfo()
        {
            return "Ferrari Testarossa 2020 - " + valorCompra;
        }
    }
}
