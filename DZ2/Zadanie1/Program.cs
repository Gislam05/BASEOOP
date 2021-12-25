// See https://aka.ms/new-console-template for more information
using Zadanie1;


SchetVBanke moySchet = new SchetVBanke();
moySchet.Balans = 800.93m;
moySchet.TypeScheta = type.Budgetny;
moySchet.Number = "5469600147901901";
Console.WriteLine();
Console.WriteLine($"Номер счета: {moySchet.Number} \n Тип счета: {moySchet.TypeScheta} \n Баланс: {moySchet.Balans}");
