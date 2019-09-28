using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator.GUI
{
    class Kalkylator
    {
        public long Value1 { get; set; }
        public long Value2 { get; set; }
        
        public long Add()
        {
            long result = Value1 + Value2;
            return result;
        }

    }
}
