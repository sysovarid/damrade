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
            RaportHelper raportHelper = new RaportHelper();

            while (true)
            {
                Console.WriteLine("1. Wybierz plik wejściowy");
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
                            if (WorkSpaceItemCollection.WebsiteContent != null)
                            {

                            }
                            Console.Clear();
                            Console.WriteLine("Czy pobrać plik z internetu?[T/N]");
                            string result = Console.ReadLine().ToUpper();

                            switch (result)
                            {
                                case "T":
                                    {
                                        Console.WriteLine("Podaj ścieżkę");
                                        webHelper.connectionPath = Console.ReadLine();
                                        webHelper.GetAllContentToList();

                                        if(webHelper.IsValidPath)
                                        {
                                             CountHelper countHelper = new CountHelper();
                                        }

                                        break;
                                    }

                                case "N":
                                    {
                                        Console.WriteLine("Podaj nazwę pliku.txt");
                                        webHelper.connectionPath = Console.ReadLine();
                                        webHelper.GetAllContentFromLocal();

                                        if (webHelper.IsValidPath)
                                        {
                                            CountHelper countHelper = new CountHelper();
                                        }

                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Nie wybrałeś poprawnie");
                                        break;
                                    }
                            }
                            break;
                        }

                    case "2":
                        {
                            Console.Clear();

                            if (WorkSpaceItemCollection.CountSentences != 0)
                            {
                                 Console.WriteLine($"Ilość liter w tekście: {WorkSpaceItemCollection.CountLetters} {Environment.NewLine}");
                            }
                            else
                            {
                                Console.WriteLine("Nie załadowałeś pliku lub plik nie posiada wartości szukanej!..");
                            }

                            break;
                        }

                    case "3":
                        {
                            Console.Clear();
                            if (WorkSpaceItemCollection.CountWords != 0)
                            {
                                Console.WriteLine($"Ilość słów w tekście: {WorkSpaceItemCollection.CountWords}{Environment.NewLine}");
                            }
                            else
                            {
                                Console.WriteLine("Nie załadowałeś pliku lub plik nie posiada wartości szukanej!..");
                            }

                            break;
                        }

                    case "4":
                        {
                            Console.Clear();

                            if (WorkSpaceItemCollection.CountPunctuationMarks != 0)
                            {
                                Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountPunctuationMarks}{Environment.NewLine}");
                            }
                            else
                            {
                                Console.WriteLine("Nie załadowałeś pliku!...");
                            }

                            break;
                        }

                    case "5":
                        {
                            Console.Clear();

                            if (WorkSpaceItemCollection.CountSentences != 0)
                            {
                                Console.WriteLine($"Ilość znaków w tekście: {WorkSpaceItemCollection.CountSentences}{Environment.NewLine}");
                            }
                            else
                            {
                                Console.WriteLine("Nie załadowałeś pliku lub plik nie posiada wartości szukanej!..");
                            }

                            break;
                        }

                    case "6":
                        {
                            Console.Clear();

                            if (WorkSpaceItemCollection.WebsiteContent != null)
                            {
                                raportHelper.GenerateReport();
                             
                            }
                            else
                            {
                                Console.WriteLine("Nie załadowałeś pliku lub plik nie posiada wartości szukanej!..");
                            }
                            
                            break;
                        }

                    case "7":
                        {
                            Console.Clear();

                            if (WorkSpaceItemCollection.WebsiteContent != null)
                            {
                                raportHelper.SaveStatistics();
                            }
                            else
                            {
                                Console.WriteLine("Nie załadowałeś pliku lub plik nie posiada wartości szukanej!..");
                            }
                            break;
                        }

                    case "8":
                        {
                            if(WorkSpaceItemCollection.WebsiteContent != null)
                            {
                                raportHelper.DeleteStatistics();
                            }

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
