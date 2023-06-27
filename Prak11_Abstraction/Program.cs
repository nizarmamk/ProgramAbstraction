using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new Laserjet();

            epson.Brand = "Epson\n";
            epson.Show = "Epson Display Dimension : 10*11\n";

            canon.Brand = "Canon\n";
            canon.Show = "Canon Display Dimension : 9.5*12\n";

            laserjet.Brand = "LaserJet\n";
            laserjet.Show = "LaserJet Display Dimension : 11*12\n";

            Console.WriteLine("==============================================");
            Console.WriteLine(" Select a Printer : ");
            Console.WriteLine(" 1. Epson");
            Console.WriteLine(" 2. Canon");
            Console.WriteLine(" 3. LaserJet\n");

            Console.Write(" Choose Printer Number [1...3] : ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==============================================");
            
            //perkondisian
            if (option == 1)
                epson.Print();
            else if (option == 2)
                canon.Print();
            else if (option == 3)
                laserjet.Print();
            else
                Console.WriteLine(" This ({0}) is a wrong input. Please try again!", option);

            Console.ReadLine();
            return;
        }
    }
}
