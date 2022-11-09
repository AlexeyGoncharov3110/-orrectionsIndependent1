// Написать программу которая сравнивает две строки.
// Пользователь вводит две строки. Если строки равны 
//то выводится сообщение true если нет то false.
// Примеры:
//  A = "ABC" B = "ABC" => true
//  A = "CBA" B = "ABCD" => false
Console.WriteLine("Введите две строки");
string? line1 = Console.ReadLine();
string? line2 = Console.ReadLine();
bool searchForEqualStrings= SearchForEqualStrings(line1,line2);
bool SearchForEqualStrings(string str1,string str2)
{   
string result1=str1;
string result2= str2;

return result1==result2;
}
Console.WriteLine(searchForEqualStrings);