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
            WebHelper webHelper = new WebHelper();
            CountHelper countHelper = new CountHelper();
            RaportHelper raportHelper = new RaportHelper();

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

                string menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        {
                            Console.Clear();

                            if (WorkSpaceItemCollection.WebsiteContent != null)
                            {
                                Console.WriteLine("Pobrano");
                            }
                            else
                            {
                                Console.WriteLine("Błąd w połączeniu");
                            }

                            break;
                        }

                    case "2":
                        {
                            Console.Clear();
                            countHelper.CountLetters();
                            Console.WriteLine($"Ilość liter w tekście: {WorkSpaceItemCollection.CountLetters} {Environment.NewLine}");

                            break;
                        }

                    case "3":
                        {
                            Console.Clear();
                            countHelper.CountWords();
                            Console.WriteLine($"Ilość słów w tekście: {WorkSpaceItemCollection.CountWords}{Environment.NewLine}");

                            break;
                        }

                    case "4":
                        {
                            Console.Clear();
                            countHelper.CountPunctuationMarks();
                            Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountPunctuationMarks}{Environment.NewLine}");

                            break;
                        }

                    case "5":
                        {
                            Console.Clear();
                            countHelper.CountSentences();
                            Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountSentences}{Environment.NewLine}");

                            break;
                        }

                    case "6":
                        {
                            Console.Clear();
                            raportHelper.GenerateReport();
                           
                 
                            foreach (var item in WorkSpaceItemCollection.Chars.OrderBy(x => x.Key))
                            {                            
                                if (item.Key == 'A' || item.Key == 'E' || item.Key == 'Y' || item.Key == 'I' || item.Key == 'O'
                                    || item.Key == 'Ą' || item.Key == 'Ę' || item.Key == 'U' || item.Key == 'Ó')
                                {
                                    WorkSpaceItemCollection.volwes.Add(item.Key, item.Value);
                                } else
                                {
                                    WorkSpaceItemCollection.consonant.Add(item.Key, item.Value);
                                }
                               
                            }

                            Console.WriteLine("Samogłoski: \n");
                             
                            foreach(var i in WorkSpaceItemCollection.volwes)
                            {
                                Console.WriteLine($"{i.Key} : {i.Value}");
                            }

                            Console.WriteLine("Spółgłoski: \n");
                            foreach (var i in WorkSpaceItemCollection.consonant)
                            {
                                Console.WriteLine($"{i.Key} : {i.Value}");
                            }

                            break;
                        }

                    case "7":
                        {
                            raportHelper.SaveStatistics();

                            break;
                        }

                    case "8":
                        {
                            raportHelper.DeleteStatistics();

                            return;
                        }


                    default:
                        {
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                        }
                }                
            }
        }
    }
}
