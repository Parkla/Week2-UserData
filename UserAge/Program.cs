using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal{yearOfBirth};

            Console.WriteLine("Palun sisesta oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - yearOfBirth;
            Console.WriteLine($"Oled{userAge}aastat vana");
        }
    }
}
