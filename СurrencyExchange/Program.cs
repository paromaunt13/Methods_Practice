/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу для конвертирования валюты. 
Пользователь должен иметь возможность ввести курс валюты, в которую он хочет конвертировать, 
сумму которую он хочет конвертировать.
Программа должна вывести сумму денег в соответствующей валюте.
*/

Console.WriteLine("Введите сумму для конвертации, $: ");
int money = int.Parse(Console.ReadLine());

Console.WriteLine("Ввведите обменный курс валюты: ");
double exchangeRate = double.Parse(Console.ReadLine());

double CurrencyExchange(int money, double exchangeRate)
{
    double sum = money * exchangeRate;
    return sum;
}

Console.WriteLine($"Сумма после конвертации - {CurrencyExchange(money, exchangeRate)} грн.");

Console.ReadKey(); 