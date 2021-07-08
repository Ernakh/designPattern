using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Singleton_
{
    public class PessoaSingleton
    {
        //criado ao ser acessado pela primeira vez
        private static PessoaSingleton instance = new PessoaSingleton();

        public string nome = null;

        private PessoaSingleton()
        {
            //priva construtor de chamadas externas, impossibilitando a criaçã ode novos objetos
        }

        public static PessoaSingleton getInstance()
        {
            return instance;
        }
    }
}
