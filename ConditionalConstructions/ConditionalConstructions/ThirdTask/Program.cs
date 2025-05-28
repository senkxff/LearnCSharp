namespace ThirdTask
{
    /*
     * Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, 
     * то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше число: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            if (userNumber == 5 || userNumber == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
