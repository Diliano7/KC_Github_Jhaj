using System;

namespace KC_Github_Jhaj
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.Write("Geben Sie bitte ihren Namen ein!");
            Console.WriteLine();
            string Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write(Name);
            Console.WriteLine();
            Console.Write("Ist Pyhton eine Programmiersprache?");
            Console.WriteLine();
            Console.Write("Das sind die Antwortmöglichkeiten: ja(1), nein(2), teilweise(3), kommt drauf an(4)");
            Console.WriteLine();
            Console.Write("Zum antworten geben Sie bitte 1, 2, 3 oder 4 ein");
            Console.WriteLine();
            string Antwort1 = Console.ReadLine();
            if (Antwort1 == "1") 
            {
                Console.Write("Die Antwort war richtig");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Die Antwort war leider falsch");
                Console.WriteLine();
            }


            Console.Write("Welches Symbol steht für die Programmiersprache Python?");
            Console.WriteLine();
            Console.Write("Das sind die Antwortmöglichkeiten: Adler(1), Löwe(2), Schlange(3), Schildkröte(4)");
            Console.WriteLine();
            Console.Write("Zum antworten geben Sie bitte 1, 2, 3 oder 4 ein");
            Console.WriteLine();
            string Antwort2 = Console.ReadLine();
            if (Antwort2 == "3")
            {
                Console.Write("Die Antwort war richtig");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Die Antwort war leider falsch");
                Console.WriteLine();
            }

           
            



        }
    }
}
