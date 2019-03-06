using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Bearings : IVisitable
    {
        public void AcceptVisitor(IWheelVisitor visitor)
        {
            // TODO add method here
            visitor.Visit(this);

        }
    }
}
