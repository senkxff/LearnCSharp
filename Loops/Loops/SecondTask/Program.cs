namespace SecondTask
{
    /*
     * Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
     */
    internal class Program
    {
        const decimal PERCENT = 0.07M;
        static void Main(string[] args)
        {
            Console.Write("Введите Вашу сумму вклада: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество месяцев, на которое вы ложите деньги: ");
            short monthCount = Convert.ToInt16(Console.ReadLine());

            short currentMonth = 0;
            while (currentMonth < monthCount)
            {
                deposit += deposit * PERCENT;
            }

            Console.WriteLine($"Итоговая сумма составляет: {deposit}");
        }
    }
}
