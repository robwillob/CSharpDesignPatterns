using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns

{
    public class Narrowwheel : AbstractWheel
    {
        public Narrowwheel(int size) : base(size, false) { }
    }
}
