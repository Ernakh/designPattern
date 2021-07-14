using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.State_
{
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
