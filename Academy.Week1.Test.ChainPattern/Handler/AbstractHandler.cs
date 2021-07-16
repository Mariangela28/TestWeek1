using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Test.ChainPattern.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        

        public virtual int Handle(Spesa spesa)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(spesa);
            }
            else
            {
                return 0;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        
    }
}
