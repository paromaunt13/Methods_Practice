/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет. 
Допустим, ежемесячная сумма платежа должна составлять 100 грн. 
Клиент должен выполнить 7 платежей, но может платить реже большими суммами. 
Т.е., может двумя платежами по 300 и 400 грн. Закрыть весь долг. 
Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка. 
Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга). 
*/

Console.WriteLine("Введите размер платежа, грн: ");
int paymentAmount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество платежей: ");
int payments = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сумму для погашения, грн: ");
int debtAmount = int.Parse(Console.ReadLine());

int overpayment;

CreditInfo(paymentAmount);
void CreditInfo(int paymentAmount)
{
	if (paymentAmount * payments - debtAmount < 0)
	{
        debtAmount -= payments * paymentAmount;
        Console.WriteLine($"Задолженность составляет {debtAmount} грн.");
    }
	else if (paymentAmount * payments - debtAmount > 0)
	{
        overpayment = payments * paymentAmount - debtAmount;
        Console.WriteLine($"Переплата составляет {overpayment} грн.");
    }  
    else
	{
		Console.WriteLine("Кредит закрыт, задолженность отсутствует");
	}
}

Console.ReadKey();
