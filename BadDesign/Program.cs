using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadDesign
{
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
    }

    public class Square : Rectangle
    {
        private double width;
        private double height;

        public override double Width
        {
            get { return width; }
            
            set 
            {
                width = value;
                height = value;
            }
        }

        public override double Height
        {
            get { return height; }

            set
            {
                width = value;
                height = value;
            }
        }
    }

    class AreaCalculator
    {
        public static double CalculateArea(Rectangle rect)
        {
            return rect.Width * rect.Height;
        }

        public static double CalculateArea(Square sqr)
        {
            return sqr.Width * sqr.Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect = new Rectangle() { Width = 3, Height = 2 };
            Square sqr = new Square() { Width = 2, Height = 2 };
            Rectangle rectType = new Square() { Width = 2, Height = 3 };

            double rectArea = AreaCalculator.CalculateArea(rect);
            Console.WriteLine(rectArea);

            double sqrArea = AreaCalculator.CalculateArea(sqr);
            Console.WriteLine(sqrArea);

            double rectTypeArea = AreaCalculator.CalculateArea(rectType);
            Console.WriteLine(rectTypeArea);

            Console.ReadKey(true);
        }
    }
}
