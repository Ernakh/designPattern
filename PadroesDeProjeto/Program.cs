using PadroesDeProjeto.Abstract_Factory;
using PadroesDeProjeto.Factory_Method;
using System;

namespace PadroesDeProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Factory Method

            Console.WriteLine("Factory Method");
            Console.WriteLine();

            FactoryPessoa pessoa = new FactoryPessoa();
            Pessoa p = pessoa.getPessoa("Fabrício", "M");

            Console.WriteLine(p.nome + " é do sexo " + p.sexo);

            Console.WriteLine("");
            Console.WriteLine("");

            #endregion

            #region Abstract Factory

            Console.WriteLine("Abstract Method");

            Pastelaria pastelaria = new PastelariaDaEsquina();
            PastelAssado pastelAssado = pastelaria.criarPastelAssado();
            Pastel pastel = pastelaria.criarPastel();

            pastelAssado.exibirInfoPastelAssado();
            pastel.exibirInfoPastel();

            Console.WriteLine("");
            Console.WriteLine("");

            #endregion

            #region Singleton

            Console.WriteLine("Singleton");

            

            Console.WriteLine("");
            Console.WriteLine("");

            #endregion
        }
    }
}
