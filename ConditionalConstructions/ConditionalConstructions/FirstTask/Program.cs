namespace FirstTask
{
    /*
     * Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
     * А программа сранивает два введенных числа и выводит на консоль результат сравнения 
     * (два числа равны, первое число больше второго или первое число меньше второго).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваше второе число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Первое число больше второго!");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Первое число меньше второго!");
            }
            else
            {
                Console.WriteLine("Числа равны!");
            }
        }
    }
}
