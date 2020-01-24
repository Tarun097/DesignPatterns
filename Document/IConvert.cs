using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IConvert
    {
        void Convert(Header header);

        void Convert(Footer footer);
    }
}
