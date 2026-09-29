using System;

namespace Pewarisan
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("=== Demo Inheritance ===\n");

            Console.WriteLine("1. Membuat objek Warrior (dengan konstruktor berparameter)");
            Warrior warrior = new Warrior(50, "W-001", "Astra", 100, "Stormwind");
            warrior.DisplayData();

            Console.WriteLine("\n2. Membuat objek Mage (dengan konstruktor berparameter)");
            Mage mage = new Mage(80, "M-001", "Lyonin", 90, "Dalarand");
            mage.DisplayData();

            Console.WriteLine("\n3. Membuat objek ArchMage (dengan konstruktor berparameter)");
            ArchMage archMage = new ArchMage(120, 80, "AM-001", "Sule", 110, "Karazhan");
            archMage.DisplayData();

            
            Console.WriteLine("\n4. Membuat objek Warrior dengan konstruktor default");
            Warrior defaultWarrior = new Warrior();
            defaultWarrior.DisplayData();

            Console.ReadKey();

        }
    }
}