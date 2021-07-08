using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Builder
{
    public class CarroBuilder
    {
        protected CarroProduct carro;

        public CarroBuilder()
        {
            carro = new CarroProduct(); //carro a ser construido
        }

        public virtual void buildPreço()
        {

        }

        public virtual void buildDscMotor()
        {

        }

        public virtual void buildAno()
        {

        }

        public virtual void buildModelo()
        {

        }

        public virtual void buildMontadora()
        {

        }

        public CarroProduct getCarro()//retorna o carro pronto
        {
            return carro;
        }
    }
}
