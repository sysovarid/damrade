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
            RaportHelper rh = new RaportHelper();

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
                    Console.Clear();
                    ch.CountLetters();
                    Console.WriteLine($"Ilość liter w tekście: {WorkSpaceItemCollection.CountLetters} {Environment.NewLine}");
                    continue;                              
                }
                if (menuOption == 3)
                {
                    Console.Clear();
                    ch.CountWords();
                    Console.WriteLine($"Ilość słów w tekście: {WorkSpaceItemCollection.CountWords}{Environment.NewLine}");
                    continue;
                }
                if (menuOption == 4) 
                {
                    Console.Clear();
                    ch.CountPunctuationMarks();
                    Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountPunctuationMarks}{Environment.NewLine}");
                    continue;
                }
                if (menuOption == 5) 
                {
                    Console.Clear();
                    ch.CountSentences();
                    Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountSentences}{Environment.NewLine}");
                    continue;
                }
                if (menuOption == 6)
                {
                    
                    rh.GenerateReport();
                    continue;
                }
                if (menuOption == 7)
                {
                    
                    rh.SaveStatistics();
                    continue;
                }
                if (menuOption == 8)
                {
                    rh.DeleteStatistics();
                    break;
                }
                
            }
        }
    }
}
