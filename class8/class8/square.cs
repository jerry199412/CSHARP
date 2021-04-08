using System;
using System.Collections.Generic;
using System.Text;

namespace class8
{
    class square : Shape
    {
        private double _length;
        private double _wight;

        public double Length1 { get => _length; set => _length = value; }
        public double Wight { get => _wight; set => _wight = value; }

        public square(double length,double weight)
        {
            this.Length1 = length;
            this.Wight = weight;
        }

        public override double Area()
        {
            //throw new NotImplementedException();
            return this.Length1 * this.Wight;
        }

        public override double Length()
        {
            //throw new NotImplementedException();
            return 2 * (this.Length1 + this.Wight);
        }
    }
}
