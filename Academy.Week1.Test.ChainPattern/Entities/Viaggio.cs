using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Test.ChainPattern.Entities
{
    class Viaggio : ISpesa
    {
        public Spesa[] Spese { get ; set ; }
        
        string ISpesa.Categoria { get; set; }
    }
}
