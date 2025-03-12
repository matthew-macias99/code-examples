using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class Calculator
    {
        public int Add(int x, int y) => x + y; 
        public int Subtract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;
        public int Divide(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException("Can't divide by zero");
            return x / y;
        }
        public int SquareRoot(int x)
        {
            if (x < 0) throw new ArgumentException("Can't get square root of negative number");
            return (int)Math.Sqrt(x);
        }
        public int Reciprocal(int x)
        {
            if (x == 0) throw new DivideByZeroException("Can't divide by zero");
            return 1/ x;
        }
    }   
}
