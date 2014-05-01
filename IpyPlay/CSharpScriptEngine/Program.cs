using System;
using IronPython.Hosting;

namespace CSharpScriptEngine
{
    class Program
    {
        static void Main()
        {
            // Remember: this block code simply reads the function 
            // definition contained in simple.py. It does not actually 
            // execute the function defined by the script.
            var engine = Python.CreateEngine();
            var script = engine.CreateScriptSourceFromFile("simple.py");
            var scope = engine.CreateScope();
            script.Execute(scope);

            // Now that I've defined the function by executing the script,
            // I must actually invoke the function to see its effects.
            var simpleFunc = scope.GetVariable("simple");
            simpleFunc();

            // Wait to read console.
            Console.ReadLine();
        }
    }
}
