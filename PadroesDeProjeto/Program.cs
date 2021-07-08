using PadroesDeProjeto.Abstract_Factory;
using PadroesDeProjeto.Factory_Method;
using PadroesDeProjeto.Singleton_;
using PadroesDeProjeto.Builder;
using PadroesDeProjeto.Prototype;
using System;

namespace PadroesDeProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory Method

            /*
             O acesso a um objeto concreto será feito através da interface conhecida 
            através de sua superclasse, mas o cliente também não quer (ou não pode) 
            saber qual implementação concreta estará utilizando.
             */

            Console.WriteLine("Factory Method");
            Console.WriteLine();

            FactoryPessoa pessoa = new FactoryPessoa();
            Pessoa p = pessoa.getPessoa("Fabrício", "M");

            Console.WriteLine(p.nome + " é do sexo " + p.sexo);

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Abstract Factory

            /*
             Prover uma interface para criar uma família de objetos 
            relacionados ou dependentes sem especificar suas classes concretas
             */

            Console.WriteLine("Abstract Method");

            Pastelaria pastelaria = new PastelariaDaEsquina();
            PastelAssado pastelAssado = pastelaria.criarPastelAssado();
            Pastel pastel = pastelaria.criarPastel();

            pastelAssado.exibirInfoPastelAssado();
            pastel.exibirInfoPastel();

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Singleton

            /*
            O padrão singleton é um dos padrões de projetos mais simples, 
            e é utilizado quando é necessário que exista somente uma 
            única instância de uma classe.
             */

            Console.WriteLine("Singleton");

            Console.WriteLine("");

            Console.WriteLine("Exemplo 1");

            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Os objetos referenciam a mesma instância");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Exemplo 2");



            PessoaSingleton p1 = PessoaSingleton.getInstance();
            p1.nome = "Fabrício";

            Console.WriteLine("1 - " + p1.nome);

            PessoaSingleton p2 = PessoaSingleton.getInstance();
            p2.nome = "Londero";

            Console.WriteLine("2 - " + p1.nome);

            if (p1 == p2)
            {
                Console.WriteLine("Os objetos referenciam a mesma Pessoa");
            }

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Builder

            /*
             A intenção do padrão Builder (construtor) é separar a 
            construção de um objeto complexo, de modo que o mesmo 
            processo de construção possa criar várias representações 
            diferentes
             */

            Console.WriteLine("Builder");

            ConcessionariaDirector concessionaria = new ConcessionariaDirector(new FerrariBuilder());

            concessionaria.construirCarro();

            CarroProduct carro = concessionaria.getCarro();

            Console.WriteLine(carro.modelo + " - " + carro.ano);

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Prototype

            /*
            Especificar os tipos de objetos a criar usando uma instância 
            prototípica, e criar novos objetos através da clonagem deste 
            protótipo.
            Você deseja parametrizar o funcionamento de uma parte da 
            aplicação mas não quer usar herança, pois a quantidade de 
            subclasses diferentes seria muito grande.
             */

            Console.WriteLine("Prototype");

            FerrariPrototype prototipoFerrari = new FerrariPrototype();
            CarroPrototype ferrariNova = prototipoFerrari.clonar();

            ferrariNova.setValorCompra(150000);

            CarroPrototype ferrariVelha = prototipoFerrari.clonar();
            ferrariVelha.setValorCompra(100000);

            Console.WriteLine(ferrariNova.exibirInfo());
            Console.WriteLine(ferrariVelha.exibirInfo());

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion
        }
    }
}
