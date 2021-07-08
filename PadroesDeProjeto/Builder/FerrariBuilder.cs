using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Builder
{
    public class FerrariBuilder : CarroBuilder
    {
        public override void buildPreço()
        {
            carro.preço = 10000;
        }
        public override void buildDscMotor()
        {
            carro.dscMotor = "1.0 Flex";
        }
        public override void buildAno()
        {
            carro.ano = 2020;
        }
        public override void buildModelo()
        {
            carro.modelo = "Testarossa";
        }
        public override void buildMontadora()
        {
            carro.montadora = "Ferrari";
        }
    }
}
