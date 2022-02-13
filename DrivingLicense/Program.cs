using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada"
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne, nüüd on teil võimalik juhilube taotleda"

            Console.WriteLine("Palun sisestage enda sünniaasta.");
            int yearÓfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - yearÓfBirth;

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada!");
            }

            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada!");
            }
            
            else
            {
                Console.WriteLine("Palju õnne, nüüd on teil võimalik juhilube taotleda!");
            }
            
                

            

            
          
            
        }
    }
}
