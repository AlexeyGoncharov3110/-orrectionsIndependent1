// Написать программу которая сравнивает две строки.
// Пользователь вводит две строки. Если строки равны 
//то выводится сообщение true если нет то false.
// Примеры:
//  A = "ABC" B = "ABC" => true
//  A = "CBA" B = "ABCD" => false
Console.WriteLine("Введите две строки");
string? line1 = Console.ReadLine();
string? line2 = Console.ReadLine();
Console.WriteLine(String.Equals(line1,line2));

