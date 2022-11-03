//  Написать программу которая считывает из консоли 2 числа A и B и определяет делится ли число А на B без остатка.
//  Результатом выполнения программы должно быть вывода сообщения пользователю true или false.
// true - если делится.
// false - если не делится.
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine(true);
}
else
Console.WriteLine(false);