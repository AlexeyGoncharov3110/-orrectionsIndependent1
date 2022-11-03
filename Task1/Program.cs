// Написать программу которая находит сумму 4 чисел. Числа вводятся пользователем из консоли.
//  Если пользователь ввел не число необходимо вывести пользователю сообщение "Введены некорректные данные".
Console.WriteLine("Введите 4 числа");


bool isParsedNum1 = int.TryParse(Console.ReadLine(), out int number1);
bool isParsedNum2 = int.TryParse(Console.ReadLine(), out int number2);
bool isParsedNum3 = int.TryParse(Console.ReadLine(), out int number3);
bool isParsedNum4 = int.TryParse(Console.ReadLine(), out int number4);
if(!isParsedNum1 || !isParsedNum2 || !isParsedNum3 || !isParsedNum4)
{
   Console.WriteLine("Введены некорректные данные");

}

Console.WriteLine(number1 + number2 + number3 + number4);
