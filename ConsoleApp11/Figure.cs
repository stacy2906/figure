using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public abstract class Figure
    {
        private string name;

        public Figure() { }
        public Figure(string name) 
        {
            this.name = "прямоугольник";
        }

        public string Name
        { get { return name; }
          set { name = value; }
        }

        public abstract void Area();
        public abstract void Perimeter();
        public abstract void Print();


    }
}
