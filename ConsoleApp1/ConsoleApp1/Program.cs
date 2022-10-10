using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        [DllImport("Dll1", EntryPoint = "Add")]
        static extern int Add(int a, int b);

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int result = Add(a, b);
            Console.WriteLine(a + " + " + b + " = " + result);
        }
    }
}
