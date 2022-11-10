// Написать программу которая сравнивает два массива и выводит индексы элементов в которых числа не равны.

// Пример:

// 1,2,3,5
// 1,2,3,4
// Вывод - 3 - (Число 5 и 4 не равны и находятся под индексом 3)
Console.WriteLine("Введите размер массива 1");
bool isParseSize1 = int.TryParse(Console.ReadLine(), out int size1);
if (!isParseSize1 || size1 <= 0)
{
    Console.WriteLine("Вы ввели не корректные данные");
    return;
}
Console.WriteLine("Введите размер массива 2");
bool isParseSize2 = int.TryParse(Console.ReadLine(), out int size2);
if (!isParseSize2 || size2 <= 0)
{
    Console.WriteLine("Вы ввели не корректные данные");
    return;
}
if (size1 != size2)
{
    Console.WriteLine(false);
}
else
{
    Console.WriteLine("Введите элементы перового массива");
    int[] array1 = Array(size1);
    Console.WriteLine("Введите элементы второго массива");
    int[] array2 = Array(size2);
    IndexesOfUnequalNumbers( array1 , array2);
    void IndexesOfUnequalNumbers(int[] col1, int[] col2)
    {
        for (int i = 0; i < size1; i++)
        {
            if (array1[i] != array2[i])
                Console.WriteLine($" Число {array1[i]} и число {array2[i]} не равны и находятся под индексом {i}");
        }
    }
    int[] Array(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            int number = 0;
            bool isParsedNum = false;
            while (!isParsedNum)
            {

                isParsedNum = int.TryParse(Console.ReadLine(), out number);
                if (!isParsedNum)
                {
                    Console.WriteLine("Не правильно введенны данные , повторите ввод");
                }
            }
            array[i] = number;
        }
        return array;
    }
}