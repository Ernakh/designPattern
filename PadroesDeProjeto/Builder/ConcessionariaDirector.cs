using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Builder
{
    public class ConcessionariaDirector
    {
        protected CarroBuilder montadora;

        public ConcessionariaDirector(CarroBuilder montadora)
        {
            this.montadora = montadora;
        }

        public void construirCarro()
        {
            montadora.buildPreço();
            montadora.buildDscMotor();
            montadora.buildAno();
            montadora.buildModelo();
            montadora.buildMontadora();
        }

        public CarroProduct getCarro()
        {
            return montadora.getCarro();
        }
    }
}
