// See https://aka.ms/new-console-template for more information
using Zadanie1;


SchetVBanke moySchet = new SchetVBanke(1000, type.Zamorojenny);
SchetVBanke moySchet2 = new SchetVBanke();

moySchet.snyat(60);

Console.WriteLine($"Остаток: {moySchet.Balans}");

moySchet.polojit(500);
Console.WriteLine($"Остаток: {moySchet.Balans}");
