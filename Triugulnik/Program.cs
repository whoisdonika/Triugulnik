using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triugulnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a side of the triangle : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the triangle's height : ");
            double h = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a, h);
            Console.WriteLine($"Триъгълник e със страна --> {triangle.PrintA()}, и височина, която е към нея  --> {triangle.PrintH()}");
            triangle.Print();

        }
    }
}
