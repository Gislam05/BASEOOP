// See https://aka.ms/new-console-template for more information
using Zadanie1;
Console.WriteLine("Программа написана для случая с русским алфавитом");
/*Console.WriteLine("Проверка класса А");
Console.WriteLine("Строка для шифрования: ");
ACoder c = new ACoder();
Console.WriteLine(c.Encode(Console.ReadLine()));
Console.WriteLine("Строка для дешифрования:");
Console.WriteLine(c.Decode(Console.ReadLine()));*/

Console.WriteLine("Проверка класса В");
Console.WriteLine("Строка для шифрования: ");
BCoder b = new BCoder();
Console.WriteLine(b.Encode(Console.ReadLine()));
Console.WriteLine("Строка для дешифрования:");
Console.WriteLine(b.Decode(Console.ReadLine()));