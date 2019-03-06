using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpDesignPatterns
{
    public abstract class AbstractWheel : IWheel  
    {
        private int _size;
        private bool _IsWide;
        private Spokes _spokes;
        private Bearings _bearings;

        public int Size
        {
            get
            {
                return _size;
            }    
        }

        public bool IsWide
        {
            get
            {
                return _IsWide;
            }
        }

        public AbstractWheel(int size, bool isWide)
        {
            this._size = size;
            this._IsWide = isWide;
            _spokes = new Spokes();    //added new 3-5-19 Visitor Design Pattern
            _bearings = new Bearings();  //added new 3-5-19  Visitor Design Pattern
        }

        public virtual void AcceptVisitor(IWheelVisitor visitor)  //added new 3-5-19 Visitor Design Pattern
        {

            _spokes.AcceptVisitor(visitor);      //added new 3-5-19  Visitor Design Pattern
            _bearings.AcceptVisitor(visitor);    //added new 3-5-19  Visitor Design Pattern
            visitor.Visit(this);                 //added new 3-5-19  Visitor Design Pattern
        }

        public override string ToString()
        {
            return base.GetType().Name + " with a wheel size of " + _size + " inches";
     
        }
    }
}
