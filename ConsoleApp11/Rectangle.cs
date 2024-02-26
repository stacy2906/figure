using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Rectangle: Figure
    {
        private int side1;
        private int side2;

        public Rectangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public int Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public int Side2
        { get { return side2; } 
          set {  side2 = value; }
        }

        public override int Area(int side1,int side2)
        {
            return side1*side2;
        }


    }
}
