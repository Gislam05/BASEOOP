// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите строку для переворота");

Console.WriteLine(Reverse(Console.ReadLine()));
string Reverse(string s)
{
    char[] a = s.ToCharArray();
    Array.Reverse(a);
    
    return String.Concat(a);
}
