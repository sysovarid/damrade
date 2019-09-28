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
                if (menuOption == 1) ;
                if (menuOption == 2) ;
                if (menuOption == 3) ;
                if (menuOption == 4) ;
                if (menuOption == 5) ;
                if (menuOption == 6) ;
                if (menuOption == 7) ;
                if (menuOption == 8) ;
                break;
            }
        }
    }
}
