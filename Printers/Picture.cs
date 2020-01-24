using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Picture
    {
        List<Shape> shapes = new List<Shape>();
    }

    public abstract class Shape
    {
        public abstract void Draw();
        public abstract void PrintOn(IPrinter print);
    }

    public class Ellipse : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Ellipse");
        }

        public override void PrintOn(IPrinter print)
        {
            print.Print((this));
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }

        public override void PrintOn(IPrinter print)
        {
            print.Print((this));
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override void PrintOn(IPrinter print)
        {
            print.Print((this));
        }
    }

}
