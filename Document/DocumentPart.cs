using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class DocumentPart
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public abstract void Display();

        public abstract void Save();

        public abstract void ConvertTo(IConvert converter);
    }
}
