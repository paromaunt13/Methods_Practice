/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Написать программу, в которой создайте один метод, который будет вычислять площадь и периметр прямоугольника. 
Сторони прямоугольника пользователь должен иметь возможность вводит с клавиатуры. 
*/

Console.WriteLine("Введите первую сторону прямоугольника: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую сторону прямоугольника: ");
int b = int.Parse(Console.ReadLine());

int area;
int perimetr;

AreaPerimetrRectangle(a, b, out perimetr, out area);

void AreaPerimetrRectangle(int a, int b, out int rectanglePerimetr, out int rectangleArea)
{
    rectanglePerimetr = (a + b) * 2;
    rectangleArea = a * b;
}

Console.WriteLine($"Периметр прямоугольника составляет {perimetr} \nПлощадь прямоугольника - {area}");
Console.ReadKey();