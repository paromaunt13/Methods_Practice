/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая будет вычислять сумму цифр числа N. 
Число N пользователь должен вводить с клавиатуры. 
При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). (Использовать рекурсию)
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} - " + Recursion(number));

int Recursion(int num)
{
	if (num < 10)
	{
		return num;
	}
	int firstValue = num % 10;
	int secondValue = num / 10;
	return firstValue + Recursion(secondValue);
}

Console.ReadKey();