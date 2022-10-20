using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа для подсчета суммы карт в игре <<21>>");
            Console.WriteLine("Введите количество карт в руке:");

            int N = int.Parse(Console.ReadLine());
            int result = 0;

            Console.WriteLine("<<<Подсказка>>>");
            Console.WriteLine("Для ввода карт-картинок используйте следующие сокращения:");
            Console.WriteLine("Валет - J");
            Console.WriteLine("Дама - Q");
            Console.WriteLine("Король - K");
            Console.WriteLine("Туз - T");
            Console.WriteLine("<<<>>>");

            for (int i=1; i<=N; i++)
            {


                Console.WriteLine($"Введите номинал {i}-й карты:");
                string nominal = Console.ReadLine();
                
                switch (nominal)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        result += int.Parse(nominal);
                        break;
                    case "J": 
                    case "Q": 
                    case "K": 
                    case "T":
                        result += 10;
                        break;
                    default:
                        Console.WriteLine("Нет такой карты. Введите номинал еще раз.");
                        i--;                                                                        // Для возврата к предыдущему значению счетчика, чтобы не пропустить карту
                        break;
                }
                                
            }
            Console.WriteLine($"Сумма карт на руках: {result, 4}");
                       
            Console.ReadKey(true);
        }
    }
}
