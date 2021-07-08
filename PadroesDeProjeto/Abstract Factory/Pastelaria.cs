using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Abstract_Factory
{
    public interface Pastelaria
    {
        PastelAssado criarPastelAssado();
        Pastel criarPastel();
    }
}
