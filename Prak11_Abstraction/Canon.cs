using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Canon : Printer
    {
        public override void Print()
        {
            Console.WriteLine(" Printer Brand : {0}", Brand);
            Console.WriteLine(" Display : {0}", Show);

            Console.WriteLine(" Canon Printer is printing...");
        }
    }
}
