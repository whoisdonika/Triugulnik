using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triugulnik
{
    internal class Triangle
    {
        private double a;
        private double h;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public Triangle(double a, double h)
        {
            this.a = a;
            this.h = h;
        }
        public double FaceOfTriangle()
        {
            double result;
            result = a * h / 2;
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"Страна = {a} и височина към нея = {h} , са с лице {FaceOfTriangle()}");
        }
        public double PrintA()
        {
            return a;
        }
        public double PrintH()
        {
            return h;
        }
    }
}
