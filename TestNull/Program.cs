using System;

namespace TestNull
{
    class Program
    {
        class A {
            public int a; 
        
        }
        static void Main(string[] args)
        {
            A elem1 = null;
            A elem = null;
            elem = elem1;
            elem1 = new A();
            Console.WriteLine($"elem1: {elem1.a}");
            Console.WriteLine($"elem: {elem.a}");
        }
    }
}
