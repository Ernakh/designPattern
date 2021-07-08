using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Abstract_Factory
{
    public class PastelariaDaEsquina : Pastelaria
    {
        public Pastel criarPastel()
        {
            return new PastelDaEsquina();
        }

        public PastelAssado criarPastelAssado()
        {
            return new PastelAssadoDaEsquina();
        }
    }
}
