using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi
{
    public abstract class Printer
    {
        public string jenisPrinter { get; set; }
        public string show { get; set; }
        public abstract void print();
    }
}