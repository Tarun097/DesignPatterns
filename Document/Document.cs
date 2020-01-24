using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Document
    {
        private List<DocumentPart> documentParts =  new List<DocumentPart>();

        public void AddPart(DocumentPart docPart)
        {
            documentParts.Add(docPart);
        }

        public void Open()
        {
            Console.WriteLine("Opening Document");
            foreach (var docPart in documentParts)
            {
                docPart.Display();
            }

            Console.WriteLine("Document Opened");
        }

        public void Close()
        {
            Console.WriteLine("Closing Document");

            foreach (var docPart in documentParts)
            {
                docPart.Save();
            }
            Console.WriteLine("Document Closed");
        }

        public void ConvertTo(IConvert converter)
        {
            Console.WriteLine("Converting document");
            foreach (var docPart in documentParts)
            {
                docPart.ConvertTo(converter);
            }

            Console.WriteLine("Document converted");
        }

    }
}
