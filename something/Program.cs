using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    class Program
    {
        static void Main(string[] args)
        {
            Something smth = new Something(3,8);
            int r = smth.Multiply();
            Console.WriteLine($"{r}");

            Console.WriteLine("{type X:}");
            int qa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{type Y:}");
            int az = Convert.ToInt32(Console.ReadLine());

            Something smth_2 = new Something(qa, az);
            int ert = smth_2.Multiply();
            Console.WriteLine($"{ert}");

            Console.ReadKey();
        }
    }
}
