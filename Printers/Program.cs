using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Visitor Pattern

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Ellipse());
            shapes.Add(new Rectangle());

            List<IPrinter> printers = new List<IPrinter>();
            printers.Add(new Dotmatrixprinter());
            printers.Add(new InkjetPrinter());
            printers.Add(new LaserPrinter());

            PrintAll(shapes, printers);

            Console.ReadLine();
        }

        private static void PrintAll(List<Shape> shapes, List<IPrinter> printers)
        {
            foreach (var printer in printers)
            {
                foreach (var shape in shapes)
                {
                    shape.PrintOn(printer);
                }

                Console.WriteLine();
            }
        }
    }
}
