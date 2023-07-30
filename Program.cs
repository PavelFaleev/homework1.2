
///Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


namespace SecondDigitProgram
{
class Program
 {
   static void Main(string[] args)
{
  Console.WriteLine("Введите трехзначное число:");
   int number = int.Parse(Console.ReadLine());

   int secondDigit = (number / 10) % 10;

   Console.WriteLine($"Вторая цифра числа: {secondDigit}");
  }
 }
}





//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

namespace ThirdDigitProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            // Проверяем, что число имеет три или более цифр
            if (number >= 100)
            {
                // Получаем третью цифру числа, используя арифметические операции
                int thirdDigit = (number / 100) % 10;
                Console.WriteLine($"Третья цифра числа: {thirdDigit}");
            }
            else
            {
                Console.WriteLine("Третьей цифры нет.");
            }
        }
    }
}





//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

namespace WeekendCheckProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру дня недели (от 1 до 7):");
            int dayOfWeek = int.Parse(Console.ReadLine());

            if (dayOfWeek == 6 || dayOfWeek == 7)
            {
                Console.WriteLine("Да, это выходной день.");
            }
            else
            {
                Console.WriteLine("Нет, это не выходной день.");
            }
        }
    }
}