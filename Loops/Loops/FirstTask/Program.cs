namespace FirstTask
{
    /*
     * За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада 
     * и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
     * Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение 
     * Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
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

            for (short currentMonth = 0; currentMonth < monthCount; currentMonth++)
            {
                deposit += deposit * PERCENT;
            }

            Console.WriteLine($"Итоговая сумма составляет: {deposit}");
        }
    }
}