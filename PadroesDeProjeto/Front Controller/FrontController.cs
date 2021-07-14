using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Front_Controller
{
    public class FrontController
    {
        private Dispatching Dispatching;

        public FrontController()
        {
            Dispatching = new Dispatching();
        }

        private bool estaAutenticado()
        {
            Console.WriteLine("Usuário autenticado com sucesso.");
            return true;
        }

        private void trackRequest(String request)
        {
            Console.WriteLine("Requested View: " + request);
        }

        public void dispatchRequest(String request)
        {
            trackRequest(request);

            if (estaAutenticado())
            {
                Dispatching.dispatch(request);
            }
        }
    }
}
