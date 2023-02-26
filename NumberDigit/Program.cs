/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое число =
и определяет количество разрядов данного числа. 
Пользователь должен иметь возможность вводит число с клавиатуры.
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

NumberDigit(number);
void NumberDigit(int number)
{
    switch (number)
    {
        case >= 0 and < 10:
            Console.WriteLine($"Разрядность числа {number} - единицы");
            break;
        case >= 10 and < 100:
            Console.WriteLine($"Разрядность числа {number} - десятки");
            break;
        case >= 100 and < 1000:
            Console.WriteLine($"Разрядность числа {number} - сотни");
            break;
        case >= 1000 and < 10000:
            Console.WriteLine($"Разрядность числа {number} - тысячи");
            break;
        case >= 10000 and < 100000:
            Console.WriteLine($"Разрядность числа {number} - десятки тысяч");
            break;
        case >= 100000 and < 1000000:
            Console.WriteLine($"Разрядность числа {number} - сотни тысяч");
            break;
        case >= 1000000 and < 10000000:
            Console.WriteLine($"Разрядность числа {number} - миллионы");
            break;
    }
}
