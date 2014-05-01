using System;
using IronPython.Hosting;

namespace CSharpIpyDotNet
{
    class Program
    {
        static void Main()
        {
            var ipyRuntime = Python.CreateRuntime();
            dynamic test = ipyRuntime.UseFile("dot_net_date.py");
            var today = test.today();
            Console.WriteLine(today[0].ToString("s"));
            Console.WriteLine(today[1].ToString("yyyy-MM-ddTHH:mm:ssK"));

            Console.ReadLine();
        }
    }
}
