using System;

namespace IstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib instagrami kasutada;
            //kui kasutaja on noorem kui 13, siis on ta liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");

            }

            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua");

            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd on sul võimalik luua endale Instagrami konto.");
            }
            Console.WriteLine("Kena päeva!");
           




        }
    }
}
