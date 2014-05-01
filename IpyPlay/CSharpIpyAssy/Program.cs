using System;
using IronPython.Hosting;

namespace CSharpIpyAssy
{
    class Program
    {
        static void Main()
        {
            var ipyRuntime = Python.CreateRuntime();
            dynamic test = ipyRuntime.UseFile("work_task_test.py");
            Console.WriteLine(test.test_abutting() ? 
                              "They abut!" : 
                              "No such luck.");
            Console.WriteLine(test.test_not_abutting() ?
                              "They abut!" :
                              "No such luck.");

            Console.ReadLine();

        }
    }
}
