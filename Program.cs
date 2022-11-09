//**********************************************************
//* Практическая работа №5                                 *
//* Выполнил: Гулько Э.А., группа 2-ИСП                    *
//**********************************************************


using System;


namespace PR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №5";

            int n, m;               // n - достоинство карты, m - масть карты
            string suit = "";       // итоговое название масти

            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Введите 2 числа:");
            Console.Write("n (6 <= n <= 14) = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m (1 <= m <= 4) = ");
            m = Convert.ToInt32(Console.ReadLine());

            if (m == 1)
                suit = "бубен";
            else if (m == 2)
                suit = "треф";
                else if (m == 3)
                    suit = "червей";
                    else if (m == 4)
                        suit = "пик";
                        else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Неверное число m");
                            }

            if (n == 6)
                Console.WriteLine("шестерка " + suit);
            else if (n == 7)
                    Console.WriteLine("семерка " + suit);
                else if (n == 8)
                        Console.WriteLine("восьмерка " + suit);
                    else if (n == 9)
                            Console.WriteLine("девятка " + suit);
                        else if (n == 10)
                                Console.WriteLine("десятка " + suit);
                            else if (n == 11)
                                    Console.WriteLine("валет " + suit);
                                else if (n == 12)
                                        Console.WriteLine("дама " + suit);
                                    else if (n == 13)
                                            Console.WriteLine("король " + suit);
                                        else if (n == 14)
                                                Console.WriteLine("туз " + suit);
                                            else { 
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Неверное число n");
                                            }

            Console.ReadKey();
        }
    }
}
