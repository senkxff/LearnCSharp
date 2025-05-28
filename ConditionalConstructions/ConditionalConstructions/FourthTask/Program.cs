namespace FourthTask
{
    /*
     * В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
     * Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. 
     * Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. 
     * В конце программа должна выводить сумму вклада с начисленными процентами.
     * Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine());
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму Вашего вклада: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            if (depositAmount < 100)
            {
                double percentage = (5.0 / 100) * depositAmount;
                Console.WriteLine($"Ваша сумма вклада с бонусом составляет: {depositAmount + percentage}");
            }
            else if (depositAmount >= 100 && depositAmount <= 200)
            {
                double percentage = (7.0 / 100) * depositAmount;
                Console.WriteLine($"Ваша сумма вклада с бонусом составляет: {depositAmount + percentage}");
            }
            else if (depositAmount > 200)
            {
                double percentage = (10.0 / 100) * depositAmount;
                Console.WriteLine($"Ваша сумма вклада с бонусом составляет: {depositAmount + percentage}");
            }
        }
    }
}
