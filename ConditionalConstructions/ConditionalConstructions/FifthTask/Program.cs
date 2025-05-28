namespace FifthTask
{
    /*
     * Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
     * И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
     * Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
     */
    internal class Program
    {
        private const double BONUS = 15;
        static void Main(string[] args)
        {
            Console.Write("Введите сумму Вашего вклада: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine()) + BONUS;

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
