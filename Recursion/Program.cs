/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который выведет все числа от 1 до N. 
N – число которое пользователь вводит с клавиатуры. (Использовать рекурсию)
*/


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num = 0;

Recursion(num);
void Recursion(int n)
{
     num++;
     Console.WriteLine(num);
    if (num == number)
        return;
     Recursion(num);      
}

Console.ReadKey();
