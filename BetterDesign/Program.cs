using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterDesign
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public virtual double SideLength { get; set; }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes =
                new List<Shape> 
                { 
                    new Rectangle() { Width = 3, Height = 2 },
                    new Square() { SideLength = 2 },
                    new Triangle() { Base = 4, Height = 2 }
                };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }

            Console.ReadKey(true);
        }
    }
}
