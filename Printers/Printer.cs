using System;

namespace ConsoleApp2
{

    public class Dotmatrixprinter : IPrinter
    {
        public void Print(Ellipse ellipse)
        {
            ellipse.Draw();
            Console.WriteLine("Printing ellipse on DotMatrix");
        }

        public void Print(Rectangle rectangle)
        {
            rectangle.Draw();
            Console.WriteLine("Printing rectangle on DotMatrix");
        }

        public void Print(Circle circle)
        {
            circle.Draw();
            Console.WriteLine("Printing circle on DotMatrix");
        }
    }
    public class LaserPrinter : IPrinter
    {
        public void Print(Ellipse ellipse)
        {
            ellipse.Draw();
            Console.WriteLine("Printing ellipse on LaserPrinter");
        }

        public void Print(Rectangle rectangle)
        {
            rectangle.Draw();
            Console.WriteLine("Printing rectangle on LaserPrinter");
        }

        public void Print(Circle circle)
        {
            circle.Draw();
            Console.WriteLine("Printing circle on LaserPrinter");
        }
    }
    public class InkjetPrinter : IPrinter
    {
        public void Print(Ellipse ellipse)
        {
            ellipse.Draw();
            Console.WriteLine("Printing ellipse on InkjetPrinter");
        }

        public void Print(Rectangle rectangle)
        {
            rectangle.Draw();
            Console.WriteLine("Printing rectangle on InkjetPrinter");
        }

        public void Print(Circle circle)
        {
            circle.Draw();
            Console.WriteLine("Printing circle on InkjetPrinter");
        }
    }

}
