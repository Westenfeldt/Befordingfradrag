using System;

namespace Befordingfradrag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor langt er der til dit arbejdet?");
            string afstand;
            double distance;
            double total;
            afstand = Console.ReadLine();
            distance = float.Parse(afstand);
            Console.WriteLine("Du har angivet at du har {0} antak km til arbejde", afstand);
            
            //Beregning

            if (distance < 24)
            {
                Console.WriteLine("Du kan ikke modtage fradraget");
            }
            else if (distance >= 24 && distance <= 100)
            {
                Console.WriteLine("Du kan modtage 154 øre pr km");

                total = (distance * 154) / 100;

                Console.WriteLine("Du kan modtage {0} kr i fradrag", total);
            }
            else if (distance > 100)
            {
                Console.WriteLine("Du kan modtage 77 øre pr km");

                total = (distance * 77) / 100;

                Console.WriteLine("Du kan modtage {0} kr i fradrag", total);

            }


        }
    }
}
