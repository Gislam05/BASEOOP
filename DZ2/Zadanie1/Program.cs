// See https://aka.ms/new-console-template for more information
using Zadanie1;


SchetVBanke moySchet = new SchetVBanke(1000, type.Zamorojenny);
SchetVBanke moySchet2 = new SchetVBanke(300, type.Budgetny);

moySchet.snyat(60);
Console.WriteLine($"Состояние до перевода: Счет 1 = {moySchet.Balans} Счет 2 = {moySchet2.Balans}");
moySchet.perevod(moySchet2, 200);
Console.WriteLine($"Результат после перевода:  Счет 1 = {moySchet.Balans} Счет 2 = {moySchet2.Balans}");
Console.WriteLine($"Остаток: {moySchet.Balans}");

moySchet.polojit(500);
Console.WriteLine($"Остаток: {moySchet.Balans}");
