// See https://aka.ms/new-console-template for more information
using Zadanie1;


SchetVBanke moySchet = new SchetVBanke();
SchetVBanke moySchet2 = new SchetVBanke();
moySchet.Balans = 800.93m;
moySchet.TypeScheta = type.Budgetny;
moySchet.Number = "5469600147901901"+ SchetVBanke.generator.ToString();
moySchet2.Number = "5469600147901901" + SchetVBanke.generator.ToString(); //В целом задача выполнена, уникальный номер генерируется, а вот более красиво так,
                                                                          //чтобы соответствовало требованиям конкретного банка можно потом модифицировать код

Console.WriteLine($"Номер счета: {moySchet.Number} \n Тип счета: {moySchet.TypeScheta} \n Баланс: {moySchet.Balans}");
Console.WriteLine($"Номер счета: {moySchet2.Number} \n Тип счета: {moySchet2.TypeScheta} \n Баланс: {moySchet2.Balans}");
