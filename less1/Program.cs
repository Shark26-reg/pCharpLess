using System;


/*
Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
*/


class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Недостаточно аргументов " );
            return;
        }

        double a, b;
        if (!double.TryParse(args[0], out a))
        {
            Console.WriteLine("Некорректный формат числа: " + args[0]);
            return;
        }

        if (!double.TryParse(args[2], out b))
        {
            Console.WriteLine("Некорректный формат числа: " + args[2]);
            return;
        }

        char operation = args[1][0];
        double result = 0;

        switch (operation)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("На 0 делить нельзя");
                    return;
                }
                result = a / b;
                break;
            default:
                Console.WriteLine("Неизвестная операция: " + args[1]);
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
