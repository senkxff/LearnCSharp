namespace SeventhTask
{
    internal class Program
    {
        /*
         * Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с 
         * введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). 
         * Результа операции выводиться на консоль.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваше второе число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию - 1.Сложение, 2.Вычитание, 3.Умножение, 4.Делить: ");
            byte operation = Convert.ToByte(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Сумма составляет: {firstNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Разность составляет: {firstNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"Произведение составляет: {firstNumber * secondNumber}");
                    break;
                case 4:
                    Console.WriteLine($"Частное составляет: {firstNumber / secondNumber}");
                    break;
                default:
                    Console.WriteLine("Неверная задача!");
                    break;
            }
        }
    }
}
