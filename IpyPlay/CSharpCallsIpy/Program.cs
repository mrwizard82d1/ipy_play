using System;
using IronPython.Hosting;

namespace CSharpCallsIpy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipyRuntime = Python.CreateRuntime();
            dynamic test = ipyRuntime.UseFile("simple.py");
            test.simple();
            // test.non_existent_method();

            Console.ReadLine();
        }
    }
}
