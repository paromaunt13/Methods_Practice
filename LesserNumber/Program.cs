/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу в которой создайте метод, который в качестве аргументов принимает 2 числа и возвращает меньшее из них.
*/

int NumberCompare(int a, int b)
{
    int result = a < b ? a : b;
    return result;
}
Console.WriteLine(NumberCompare(9, 13));

Console.ReadKey();