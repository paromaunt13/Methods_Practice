/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, 
который принимает в качестве аргумента год рождения пользователя и возвращает его полный возраст. 
*/

Console.WriteLine("Введите год Вашего рождения: ");
int year = int.Parse(Console.ReadLine());

static int AgeDefinition(int year)
{
    int age = DateTime.Now.Year - year;
    return age;
}

Console.WriteLine($"Ваш возраст - {AgeDefinition(year)}");

Console.ReadKey();