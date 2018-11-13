using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Type console = typeof(Console);
            MethodInfo[] methods = console.GetMethods();
            Console.WriteLine("*** Methods of class Console ***\n");
            foreach (MethodInfo method in methods)
            {
                Console.Write("-->" + method.ReturnType.Name + "\t" + method.Name + "(");
                ParameterInfo[] parametr = method.GetParameters();
                for (int i = 0; i < parametr.Length; i++)
                {
                    Console.Write(parametr[i].ParameterType.Name + " " + parametr[i].Name);
                    if (i + 1 < parametr.Length) Console.Write(", ");
                }
                Console.Write(")\n");
            }

            Console.ReadLine();
        }
    }
}
