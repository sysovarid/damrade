using analizator.Helpers;
using analizator.WorkSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizator
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHelper wh = new WebHelper();
            CountHelper ch = new CountHelper();

            while (true)
            {
                Console.WriteLine("1. Pobierz plik z internetu");
                Console.WriteLine("2. Zlicz liczbę liter w pobranym pliku");
                Console.WriteLine("3. Zlicz liczbę wyrazów w pliku");
                Console.WriteLine("4. Zlicz liczbę znaków interpunkcyjnych w pliku");
                Console.WriteLine("5. Zlicz liczbę zdań w pliku");
                Console.WriteLine("6. Wygeneruj raport o użyciu liter");
                Console.WriteLine("7. Zapisz statystyki z punktów 2-5 do pliku statystyki.txt");
                Console.WriteLine("8. Wyjście z programu");
                int menuOption = Convert.ToInt32(Console.ReadLine());

                if (menuOption == 1)
                {
                    if (WorkSpaceItemCollection.WebsiteContent != null)
                    {
                        Console.WriteLine("Połączono");
                    }
                    else
                    {
                        Console.WriteLine("Błąd w połączeniu");
                    }
                    continue;   
                }
                if (menuOption == 2)
                {                 
                    ch.CountLetters();
                    Console.WriteLine($"Ilość liter w tekście: {WorkSpaceItemCollection.CountLetters}");
                    continue;                              
                }
                if (menuOption == 3)
                {              
                    ch.CountWords();
                    Console.WriteLine($"Ilość słów w tekście: {WorkSpaceItemCollection.CountWords}");
                    continue;
                }
                if (menuOption == 4) 
                {
                    ch.CountPunctuationMarks();
                    Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountPunctuationMarks}");
                    continue;
                }
                if (menuOption == 5) 
                {               
                    ch.CountSentences();
                    Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountSentences}");
                    continue;
                }
                if (menuOption == 6)
                {
                    RaportHelper rh = new RaportHelper();
                    rh.GenerateReport();
                    continue;
                }
                if (menuOption == 7)
                {
                    RaportHelper rh = new RaportHelper();
                    rh.SaveStatistics();
                    continue;
                }
                if (menuOption == 8)
                    break;
                
            }
        }
    }
}
