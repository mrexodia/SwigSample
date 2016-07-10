using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swig.SwigSample;

namespace CSharpCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            SwigSample.Test();
            int a = 5, b = 8;
            Console.WriteLine("Add({0}, {1}) = {2}", a, b, SwigSample.Add(a, b));
            var myStruct = new MyStruct();
            myStruct.a = a;
            myStruct.b = b;
            Console.WriteLine("AddStruct({0}, {1}) = {2}", myStruct.a, myStruct.b, SwigSample.AddStruct(myStruct));
            Console.ReadKey();
        }
    }
}
