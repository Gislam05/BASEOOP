using Zadanie1;

Building home = new Building();


Console.WriteLine("Введите через Enter высоту, количество квартир, этажей и подъездов");
home.High = int.Parse (Console.ReadLine());
home.Apartment = int.Parse(Console.ReadLine());
home.Stage = int.Parse(Console.ReadLine());
home.Porch = int.Parse(Console.ReadLine());

Console.WriteLine($"Высота каждого этажа равна {home.StageHigh()} метров. В каждом подъезде {home.PorchApartment()} квартир. На каждом этаже {home.ApartmentStage()} квартир.");

Console.WriteLine("Набери номер квартиры, а я угадаю этаж и подъезд");
home.Adress(int.Parse(Console.ReadLine()));


