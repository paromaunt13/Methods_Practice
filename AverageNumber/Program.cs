/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу в которой создайте метод,
который принимает в качестве параметров три целочисленных аргумента 
и выводит на экран среднее арифметическое значений аргументов.
*/

Average(9, 13, 95);
static void Average(int a, int b, int c)
{
    double averageNumber = (double)(a * b + c)/3;
    Console.WriteLine($"Среднее арифметическое чисел {a}, {b} и {c} равно {averageNumber}");
}

Console.ReadKey();