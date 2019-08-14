using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    public class Something
    {
        public int X {get;set;}
        public int Y { get; set; }

        public Something()
        {
        }

        public Something(int n, int m)
        {
            X = n;
            Y = m;
        }
        public int Multiply()
        {
            return X + Y;
        }
    }
}
