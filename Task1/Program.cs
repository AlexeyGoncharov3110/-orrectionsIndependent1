// Написать программу которая находит сумму 4 чисел. Числа вводятся пользователем из консоли.
//  Если пользователь ввел не число необходимо вывести пользователю сообщение "Введены некорректные данные".
Console.WriteLine("Введите 4 числа");
int size = 4;
int[] array = Array(size);
int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        bool isParsedNum = int.TryParse(Console.ReadLine(), out int number);
        if (!isParsedNum)
        {
            Console.WriteLine("Введены некорректные данные");
            break;
        }
        array[i] = number;
    }
    return array;
}
Console.WriteLine(array[0] + array[1] + array[2] + array[3]);
