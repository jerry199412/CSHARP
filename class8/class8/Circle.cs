using System;
using System.Collections.Generic;
using System.Text;

namespace class8
{
    class Circle : Shape
    {
        private double _rl;

        public double Rl { get => _rl; set => _rl = value; }

        public Circle(double r)
        {
            this.Rl = r;
        }

        public override double Area()
        {
            //throw new NotImplementedException();
            return Math.PI * this.Rl * this.Rl;
        }

        public override double Length()
        {
            //throw new NotImplementedException();
            return 2 * Math.PI * this.Rl;
        }
    }
}
