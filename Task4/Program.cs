// Написать программу которая заполняет массив рандомными числами.
//  Количество рандомных чисел пользователь задает из консоли. 
//  Вывести заполненый массив в консоль.
// Пример: Вввели 3 => 7, 4, 5

Console.WriteLine("Введите размер массива");
bool isParseSize = int.TryParse(Console.ReadLine(), out int size);
if (!isParseSize)
{
    Console.WriteLine("Вы ввели не корректные данные");
}
int[] array = Array(size);
int[] Array(int size)
{
    int[] array = new int[size];
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 10);
        array[i] = randomNumber;
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    return array;
}
