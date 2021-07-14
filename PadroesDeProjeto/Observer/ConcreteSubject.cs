using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Observer
{
    public class ConcreteSubject : Subject
    {
        private string subjectState;
        // Gets or sets subject state
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
