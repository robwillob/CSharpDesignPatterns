﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpDesignPatterns
{
    public interface IWheel : IVisitable   //added this interface 3/5/19
    {
        int Size { get;}
        bool IsWide { get;}

        void AcceptVisitor(IWheelVisitor visitor);
    }
}
