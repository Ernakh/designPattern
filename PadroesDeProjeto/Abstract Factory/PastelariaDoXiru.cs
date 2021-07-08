using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Abstract_Factory
{
    public class PastelariaDoXiru : Pastelaria
    {
        public Pastel criarPastel()
        {
            return new PastelDoXiru();
        }

        public PastelAssado criarPastelAssado()
        {
            return new PastelAssadoDoXiru();
        }
    }
}
