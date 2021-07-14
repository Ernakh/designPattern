using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Front_Controller
{
    public class Dispatching
    {
        private AlunoView alunoView;
        private ProfessorView professorView;

        public Dispatching()
        {
            alunoView = new AlunoView();
            professorView = new ProfessorView();
        }

        public void dispatch(String request)
        {
            if (request.Equals("Aluno"))
            {
                alunoView.display();
            }
            else
            {
                professorView.display();
            }
        }
    }
}
