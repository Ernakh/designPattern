using PadroesDeProjeto.Abstract_Factory;
using PadroesDeProjeto.Factory_Method;
using PadroesDeProjeto.Singleton_;
using PadroesDeProjeto.Builder;
using PadroesDeProjeto.Facade_;
using PadroesDeProjeto.Prototype;
using PadroesDeProjeto.Composite;
using System;
using PadroesDeProjeto.Adapter_;
using PadroesDeProjeto.Front_Controller;
using PadroesDeProjeto.Decorator;
using PadroesDeProjeto.Bridge;
using PadroesDeProjeto.Mediator_;
using PadroesDeProjeto.State_;
using PadroesDeProjeto.Template_Method;
using PadroesDeProjeto.Chain_of_Responsibility;
using PadroesDeProjeto.Command_;
using PadroesDeProjeto.Iterator_;
using PadroesDeProjeto.Strategy_;
using System.Collections.Generic;
using PadroesDeProjeto.Visitor;
using PadroesDeProjeto.Memento_;
using PadroesDeProjeto.Interpreter;
using PadroesDeProjeto.Observer;

namespace PadroesDeProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIAÇÃO

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

            Pastelaria pastelaria = new PastelariaDoXiru();
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

            //ESTRUTURA

            #region Facade

            /*
              Uma Fachada
                É um padrão que cria uma interface simples, de alto nível, para interfaces complexas. 
                Com isso a visão do usuário é de que a operação é simples, quando - na verdade - não o é.
             */

            Console.WriteLine("Facade");
            Console.WriteLine();

            Facade facade = new Facade();
            facade.MetodoA();
            facade.MetodoB();

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Composite

            /*
            objetivo é Compor objetos em uma estrutura de árvore 
            com o objetivo de representar hierarquias do tipo parte-todo
             */

            Console.WriteLine("Composite");
            Console.WriteLine();

            PresenteUnico fone = new PresenteUnico("Smartphone", 256);
            fone.CalcularPrecoTotal();

            CompositePresente caixa = new CompositePresente("caixa", 0);
            PresenteUnico brinquedo1 = new PresenteUnico("brinquedo1", 289);
            PresenteUnico brinquedo2 = new PresenteUnico("brinquedo2", 587);
            caixa.Adicionar(brinquedo1);
            caixa.Adicionar(brinquedo2);
            CompositePresente caixa2 = new CompositePresente("caixa2", 0);
            PresenteUnico brinquedo3 = new PresenteUnico("brinquedo3", 200);
            caixa2.Adicionar(brinquedo3);
            caixa.Adicionar(caixa2);
            Console.WriteLine($"Preço total do presente composto: {caixa.CalcularPrecoTotal()}");

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Adapter

            /*
           Uma biblioteca é projetada para ser reusada.
            Entretanto, a interface da biblioteca (assinatura dos métodos) 
            pode não ser exatamente a esperada pela aplicação.
            Permitir que classes com interfaces incompatíveis trabalhem juntos

             */

            Console.WriteLine("Adapter");
            Console.WriteLine();

            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Front Controller

            /*
           
             */

            Console.WriteLine("Front Controller");
            Console.WriteLine();

            FrontController frontController = new FrontController();
            frontController.dispatchRequest("Professor");
            frontController.dispatchRequest("Aluno");

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Decorator

            /*
            Decorator é um padrão de projeto do tipo estrutural, 
            e é utilizado para adicionar dinamicamente novas funcionalidades a um objeto;

             */

            Console.WriteLine("Decorator");
            Console.WriteLine();

            PessoaNormal pessoaNormal = new PessoaNormal();

            Console.WriteLine("usando Pessoa Normal:");
            Console.WriteLine(pessoaNormal.Andar());

            Console.WriteLine();

            PessoaRapida pessoaRapida = new PessoaRapida(pessoaNormal);

            Console.WriteLine("usando PessoaRapida:");
            Console.WriteLine(pessoaRapida.Andar());
            Console.WriteLine(pessoaRapida.Correr());

            Console.WriteLine();

            PessoaLenta pessoaLenta = new PessoaLenta(pessoaNormal);

            Console.WriteLine("usando PessoaLenta:");
            Console.WriteLine(pessoaLenta.Andar());

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Bridge

            /*
           Utilizado quando deseja que uma interface poderá variar sem depender das suas implementações
             */

            Console.WriteLine("Bridge");
            Console.WriteLine();

            Abstraction ab = new RefinedAbstraction();
            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();


            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            //COMPORTAMENTO

            #region Mediator

            /*
             Diminuir a quantidade de “ligações” entre objetos introduzindo 
            um mediador, através do qual toda comunicação entre os objetos 
            será realizada.

             */

            Console.WriteLine("Mediator");
            Console.WriteLine();

            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);
            m.Colleague1 = c1;
            m.Colleague2 = c2;
            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region State

            /*
             Alterar o comportamento de um determinado objeto 
            de acordo com o estado no qual ele se encontra.

             */

            Console.WriteLine("State");
            Console.WriteLine();

            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Template Method

            /*
             Definir a ordem na qual determinados passos devem ser realizados na resolução de um problema 
                Permitir que esses passos possam ser realizados de formas diferentes de acordo com a situação.
            Um Template Method auxilia na definição de um algoritmo com partes do mesmo definidos por Método abstratos. 
             */

            Console.WriteLine("Template Method");
            Console.WriteLine();

            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Chain of Responsibility

            /*
             - Varios objetos podem receber/tratar uma requisição
             - O remetente não sabe quem vai tratar a solução
             - Varios vão receber, até chegar naquele que resolve o problema
             */

            Console.WriteLine("Chain of Responsibility");
            Console.WriteLine();

            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Command

            /*
             Tem como objetivo controlar as chamadas a um determinado componente, 
             modelando cada requisição como um objeto
             */

            Console.WriteLine("Command");
            Console.WriteLine();

            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Iterator

            /*
             Fornecer um modo eficiente para percorrer sequencialmente os 
             elementos de uma coleção, sem que a estrutura interna da coleção 
             seja exposta.
            */

            Console.WriteLine("Iterator");
            Console.WriteLine();

            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Strategy

            /*
             Geralmente é usado em várias estruturas para fornecer aos 
            usuários uma maneira de alterar o comportamento de uma classe 
            sem estendê-la.
             */

            Console.WriteLine("Strategy");
            Console.WriteLine();

            Contexto contexto;
            // Three contexts following different strategies
            contexto = new Contexto(new ConcreteStrategyA());
            contexto.ContextInterface();
            contexto = new Contexto(new ConcreteStrategyB());
            contexto.ContextInterface();
            contexto = new Contexto(new ConcreteStrategyC());
            contexto.ContextInterface();

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Visitor

            //****************************************************

            /*
             Representar uma operação a ser executada nos elementos 
             de uma estrutura de objetos. Visitor permite definir uma 
             nova operação sem mudar as classes dos elementos sobre os 
             quais opera.
             */

            Console.WriteLine("Visitor");
            Console.WriteLine();

            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            ClienteVisitor.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            ClienteVisitor.ClientCode(components, visitor2);

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Memento

            /*
             Sem violar o encapsulamento, capturar e externalizar um 
            estado interno de um objeto, de maneira que o objeto possa 
            ser restaurado para esse estado mais tarde.
             */

            Console.WriteLine("Memento");
            Console.WriteLine();

            Originator o = new Originator();
            o.State = "On";
            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            // Continue changing originator
            o.State = "Off";
            // Restore saved state
            o.SetMemento(c.Memento);

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Interpreter

            /*
             Dada uma linguagem, definir uma representação para sua 
            gramática juntamente com um interpretador que usa a 
            representação para interpretar sentenças dessa linguagem
             */

            Console.WriteLine("Interpreter");
            Console.WriteLine();

            ContextoInterpreter contextoInterpreter = new ContextoInterpreter();
            // Usually a tree 
            List<AbstractExpression> list = new List<AbstractExpression>();
            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(contextoInterpreter);
            }

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion

            #region Observer

            /*
             Ele fornece uma maneira de reagir a eventos que acontecem em outros objetos sem acoplar às suas classes.
             */

            Console.WriteLine("Observer");
            Console.WriteLine();

            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();


            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

            #endregion
        }
    }
}
