using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Test.ChainPattern.Entities
{
    class Altro : ISpesa
    {
        public Spesa[] Spese { get; set; }
        public string Categoria { get; set; }
    }
}
