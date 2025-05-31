namespace ThirdTask
{
    /*
     * Напишите программу, которая выводит на консоль таблицу умножения 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения: ");

            for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
