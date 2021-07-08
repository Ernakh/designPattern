using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Singleton_
{
    //implementação básica
    public class Singleton
    {
        //objeto que mantem a instnacia da classe
        private static Singleton instance = null;

        private Singleton()
        {
            //Por tornar privado, não permtie que novas instancias sejam criadas
        }

        public static Singleton getInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
