using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен_квал
{
    class Program//Хандусь В.
    {
        static void Main(string[] args)
        {
            int arraySize;
            Console.WriteLine("Введите размер массива (целое число больше 1):");
            if (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 1)
            {
                Console.WriteLine("Ошибка: размер массива должен быть целым числом больше 1.");
                return;
            }

            //Инициализация массивов Хандусь В.
            int[] prices = new int[arraySize];
            int[] respondents = new int[arraySize];

            //Заполнение массивов Хандусь В.
            Console.WriteLine("Введите значения цен и количества респондентов:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Цена [{i}]: ");
                prices[i] = int.Parse(Console.ReadLine());
                Console.Write($"Количество респондентов [{i}]: ");
                respondents[i] = int.Parse(Console.ReadLine());
            }

            //Запрос себестоимости товара Хандусь В.
            Console.WriteLine("Введите себестоимость товара:");
            int costPrice = int.Parse(Console.ReadLine());

            //Расчет и вывод результата Хандусь В.
            CalculateOptimalPrice(prices, respondents, costPrice);
        }

        static void CalculateOptimalPrice(int[] prices, int[] respondents, int costPrice)//Алгоритм Хандусь В.
        {
            int maxProfit = int.MinValue;
            int optimalPrice = 0;
            int optimalDemand = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                int revenue = prices[i] * respondents[i];
                int profit = revenue - (costPrice * respondents[i]);

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    optimalPrice = prices[i];
                    optimalDemand = respondents[i];
                }
            }
            //Вывод информации Хандусь В.
            Console.WriteLine($"Оптимальная цена: {optimalPrice}");
            Console.WriteLine($"Спрос на товар при оптимальной цене: {optimalDemand}");
            Console.WriteLine($"Максимальная прибыль: {maxProfit}");
            Console.WriteLine($"Количество значений ниже себестоимости: {prices.Count(p => p < costPrice)}");

            Console.WriteLine("Работу выполнил студент: Хандусь Виктор Сеергевич");
            Console.WriteLine($"Группа: 34ИС");
            string studentGroup = Console.ReadLine();
        }
    }
}

