using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Facade_
{
    public class Facade
    {
        SubSistema1 sub1;
        SubSistema2 sub2;
        SubSistema3 sub3;

        public Facade()
        {
            sub1 = new SubSistema1();
            sub2 = new SubSistema2();
            sub3 = new SubSistema3();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMetodoA() ---- ");
            sub1.Metodo1();
            sub3.Metodo3();
        }
        public void MetodoB()
        {
            Console.WriteLine("\nMetodoB() ---- ");
            sub1.Metodo1();
            sub2.Metodo2();
            sub3.Metodo3();
        }
    }
}