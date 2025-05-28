namespace SixthTask
{
    /*
     * Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". 
     * Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. 
     * Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
     * Для определения операции по введенному номеру используйте конструкцию switch...case.
     * Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, 
     * что операция неопределена.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 5.0; double secondNumber = 10.0; 

            Console.Write("Выберите операцию для (5 и 10) 1.Сложение, 2.Вычитание, 3.Умножение, 4.Делить: ");
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
