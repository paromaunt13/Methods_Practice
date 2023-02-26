/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу консольный калькулятор. 
В данной программе должны быть четыре метода, метод для сложения, вычитания, умножения и деления. 
Каждый из методов должен принимать 2 целочисленных аргумента и выполнять соответствующею действие. 
Метод для деления должен выполнять проверку деления на ноль. 
Также необходимо предоставить пользователю возможность вводить знак арифметической операции, 
в зависимости от знака вызывать соответствующий метод.
Также пользователю необходимо предоставить возможность вводит значения аргументов.  
*/
NumberInput:
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите знак арифметичской операции: ");
string sign = Console.ReadLine();

int Addition(int a, int b)
{
    int result = a + b;
    return result;
}
int Subtract(int a, int b)
{
    int result = a - b;
    return result;
}
int Multiply(int a, int b)
{
    int result = a * b;
    return result;
}
float Division(int a, int b)
{
    float result = (float)a / b;
    return result;
}

switch (sign)
{
    case "+":
        Console.WriteLine($"Результат сложения {a} и {b} равен {Addition(a, b)}");
        break;
    case "-":
        Console.WriteLine($"Результат вычитания {a} и {b} равен {Subtract(a, b)}");
        break;
    case "*":
        Console.WriteLine($"Результат умножения {a} и {b} равен {Multiply(a, b)}");
        break;
    case "/":
        if (b == 0)
        {
            Console.WriteLine("На ноль делить нельзя!");
            goto NumberInput;
        }
        Console.WriteLine($"Результат деления {a} и {b} равен {Division(a, b)}");
        break;
}

Console.ReadKey();