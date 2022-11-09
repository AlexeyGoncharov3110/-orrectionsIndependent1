//  Написать программу которая сравнивает два массива. 
//  На вход пользователь заполняет два массива.
//  Если каждый элемент массива равен каждому элементу 
//  второго массива вывести true, если хотя бы один не равен то вывести false.
// Пример:
// 1,2,3,4
// 1,2,3,4
// Вывод - true
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
    Console.WriteLine("Введите элементы массива 1");
    int[] array1 = Array(size1);
    Console.WriteLine("Введите элементы массива 2");
    int[] array2 = Array(size2);
    bool ComparingArrays(int[] arr1, int[] arr2)
    {
        int count = 0;
        for (int i = 0; i < size1; i++)
        {
            if (array1[i] == array2[i]) count++;
        }
        return count == size1;
    }
    int[] Array(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            bool isParsedNum = int.TryParse(Console.ReadLine(), out int number);
            if (!isParsedNum)
            {
                Console.WriteLine("Введены некорректные данные, повторите ввод");
                i--;
            }
            else
            {
                array[i] = number;
            }
        }
        return array;
    }
    bool comparingArrays = ComparingArrays(array1, array2);
    Console.WriteLine(comparingArrays);
}