using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Test.ChainPattern.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        int Handle(Spesa spesa);
    }
}
