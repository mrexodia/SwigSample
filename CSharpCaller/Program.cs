using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            SwigSample.Test();
            int a = 5, b = 8;
            Console.WriteLine("Add({0}, {1}) = {2}", a, b, SwigSample.Add(a, b));
            Console.ReadKey();
        }
    }
}
