using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi
{
    public class LaserJet : Printer
    {
        public override void print()
        {
            Console.WriteLine("Jenis printer : {0}", jenisPrinter);
            Console.WriteLine("Display dimension {0}", show);
            Console.WriteLine("LaserJet printer printing.....");
        }
    }
}