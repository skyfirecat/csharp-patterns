using System;

namespace Prototype
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public abstract Shape Clone();

        public override string ToString()
        {
            return $"{GetType().Name} [Color: {Color}]";
        }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return new Circle
            {
                Color = this.Color,
                Radius = this.Radius
            };
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override Shape Clone()
        {
            return new Rectangle
            {
                Color = this.Color,
                Width = this.Width,
                Height = this.Height
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle originalCircle = new Circle { Color = "Red", Radius = 10 };
            Rectangle originalRectangle = new Rectangle { Color = "Blue", Width = 20, Height = 15 };

            Circle clonedCircle = (Circle)originalCircle.Clone();
            Rectangle clonedRectangle = (Rectangle)originalRectangle.Clone();

            clonedCircle.Color = "Green";
            clonedCircle.Radius = 15;

            clonedRectangle.Color = "Yellow";
            clonedRectangle.Width = 25;

            Console.WriteLine("Original objects:");
            Console.WriteLine(originalCircle);
            Console.WriteLine(originalRectangle);

            Console.WriteLine("\nCloned objects:");
            Console.WriteLine(clonedCircle);
            Console.WriteLine(clonedRectangle);
        }
    }
}
