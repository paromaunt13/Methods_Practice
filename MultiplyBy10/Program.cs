/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, 
который принимает в качестве параметров три целочисленных значения
и возвращает значение каждого аргумента, умноженного на 10.
(Использовать out и ref)
*/

int a;
int b;
int c = 30;
int MultiplyByTen(out int a, out int b, ref int c)
{
    a = 10;
    b = 20;
    a *= 10;
    b *= 10;
    return c *= 10;
}

MultiplyByTen(out a, out b, ref c);
Console.WriteLine($"{a} + {b} + {c}");

Console.ReadKey();
