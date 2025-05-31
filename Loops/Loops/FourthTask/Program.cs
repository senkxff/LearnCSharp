namespace FourthTask
{
    /*
     * Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
     * При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. 
     * Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, 
     * и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит 
     * результат умножения.
     * Для организации ввода чисел используйте бесконечный цикл while и оператор break.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число [0,10]: ");
                sbyte firstNumber = Convert.ToSByte(Console.ReadLine());

                Console.Write("Введите второе число [0,10]: ");
                sbyte secondNumber = Convert.ToSByte(Console.ReadLine());

                if (firstNumber < 0 || firstNumber > 10 || secondNumber < 0 || secondNumber > 10)
                {
                    Console.WriteLine("Вы ввели не корректные значения!");
                }
                else
                {
                    Console.WriteLine($"Результат: {firstNumber * secondNumber}");
                    break;  
                }
            }
        }
    }
}
