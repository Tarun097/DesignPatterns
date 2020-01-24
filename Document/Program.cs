using System;
/*
 * Doc obj
	- contains document parts like header, footer, text, link
	- every document part has unique name and content
	- every document part knows how to present itself
 */


//Visitor pattern

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document();
            doc.AddPart(new Header());
            doc.AddPart(new Footer());
            
            doc.Open();
            Console.WriteLine();
            doc.Close();
            Console.WriteLine();
            //doc.ConvertTo(new HTMLConverter());

            doc.ConvertTo(new PDFConverter());

            Console.ReadKey();
        }
    }

    public class Header : DocumentPart
    {
        public override void Display()
        {
            Console.WriteLine("Displaying header");
        }

        public override void Save()
        {
            Console.WriteLine("Saving header");
        }

        public override void ConvertTo(IConvert converter)
        {
            converter.Convert(this);
        }
    }

    public class Footer: DocumentPart
    {

        public override void Display()
        {
            Console.WriteLine("Displaying Footer");
        }

        public override void Save()
        {
            Console.WriteLine("Saving Footer");
        }

        public override void ConvertTo(IConvert converter)
        {
            converter.Convert(this);
        }
    }

    public class HTMLConverter : IConvert
    {
        public void Convert(Header header)
        {
            Console.WriteLine("Converting header to HTML");
        }

        public void Convert(Footer footer)
        {
            Console.WriteLine("Converting footer to HTML");
        }
    }

    public class PDFConverter : IConvert
    {
        public void Convert(Header header)
        {
            Console.WriteLine("Converting header to PDF");
        }

        public void Convert(Footer footer)
        {
            Console.WriteLine("Converting footer to PDF");
        }
    }

}
