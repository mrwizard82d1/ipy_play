using System;
using IronPython.Hosting;

namespace CSharpDynamic
{
    class Program
    {
        static void Main()
        {
            var ipyRuntime = Python.CreateRuntime();
            dynamic test = ipyRuntime.UseFile("simple.py");
            test.simple();
            // test.non_existent_method();

            Console.ReadLine();
        }
    }
}
