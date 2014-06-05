using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadDesign2
{
    class Program
    {
        public abstract class Shape
        {}

        public class Rectangle : Shape
        {
            public virtual double Width { get; set; }
            public virtual double Height { get; set; }

            public double Area()
            {
                return Width * Height;
            }
        }

        public class Square : Shape
        {
            public virtual double SideLength { get; set; }

            public double Area()
            {
                return SideLength * SideLength;
            }
        }

        public class Triangle : Shape
        {
            public double Base { get; set; }
            public double Height { get; set; }

            public double Area()
            {
                return 0.5 * Base * Height;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle() { Width = 3, Height = 2 };
            Square sqr = new Square() { SideLength = 2 };
            Triangle tri = new Triangle() { Base = 4, Height = 2 };

            Console.WriteLine(rect.Area());
            Console.WriteLine(sqr.Area());
            Console.WriteLine(tri.Area());

            Console.ReadKey(true);

            List<Shape> shapes = 
                new List<Shape> 
                { 
                    new Rectangle() { Width = 3, Height = 2 },
                    new Square() { SideLength = 2 },
                    new Triangle() { Base = 4, Height = 2 }
                };

            foreach(Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Rectangle))
                {
                    Console.WriteLine(((Rectangle)shape).Area());
                }
                else if (shape.GetType() == typeof(Square))
                {
                    Console.WriteLine(((Square)shape).Area());
                }
                else if (shape.GetType() == typeof(Triangle))
                {
                    Console.WriteLine(((Triangle)shape).Area());
                }
            }
                
            Console.ReadKey(true);
        }
    }
}
