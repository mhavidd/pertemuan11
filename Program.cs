using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new LaserJet();

            epson.jenisPrinter = "Epson";
            epson.show = "10 * 11";

            canon.jenisPrinter = "Canon";
            canon.show = "9.5 * 12";

            laserjet.jenisPrinter = "LaserJet";
            laserjet.show = "12 * 12";

            Console.Write("1. Epson\n");
            Console.Write("2. Canon\n");
            Console.Write("3. Laserjet\n");
            Console.Write("Pilih jenis printer [1..3]: ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
                epson.print();
            else if (pilih == 2)
                canon.print();
            else
                laserjet.print();

            Console.ReadKey();
        }
    }
}