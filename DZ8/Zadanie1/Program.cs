// See https://aka.ms/new-console-template for more information
using Zadanie1;
using System.IO;

Console.WriteLine("Hello, World!");
int i = 1;
string path = "D:";
Directories dir0 = new Directories(path);
dir0.Open();

string[] com = Console.ReadLine().Split(' ');

do
{
    path = Directories.ls[int.Parse(com[1])];
    switch (com[0])
    {
        case "open":   Directories dir = new Directories(path); dir.Open(); break;
        case "close":  Directories dir2 = new Directories(path); dir2.Open(); break;
        case "create": string name = Console.ReadLine(); if (com[1] == "directory")
            { Directory.CreateDirectory(path+"\\"+name); } else { File.Create(path + "\\" + name); } break;
        case "delete": Directory.Delete(path); break;

        default: Console.WriteLine("Введите адекватную команду"); break;
    }
    com = Console.ReadLine().Split(' ');
}
while (com[0] != "exit");
