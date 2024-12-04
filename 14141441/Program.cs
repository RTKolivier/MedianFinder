using System;
using System.Collections.Generic;

public class MedianFinder
{
        public static void Main(string[] args)
        {
            MedianFinder finder = new MedianFinder();

            Console.WriteLine("Введите числа (для завершения введите 'q'):");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    finder.AddNum(number);
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное число или 'q' для завершения");
                }
            }

            Console.WriteLine($"Финальная медиана: {finder.FindMedian()}");
    }
    private List<int> numbers;

    public MedianFinder()
    {
        numbers = new List<int>();
    }

    public void AddNum(int num)
    {
        numbers.Add(num);
        numbers.Sort(); 
    }

    public double FindMedian()
    {
        int count = numbers.Count;
        if (count == 0) return 0;

        if (count % 2 == 0)
        {
            return (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}
