namespace SecondTask
{
    /*
     * Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, 
     * то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше число: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            if (userNumber > 5 && userNumber < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
