using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Directories:Operations
    {
        string path;
        
        int i = 0;
        public static Dictionary<int, string> ls; //Объекты внутри каталога: Как подкаталоги так и файлы

        public Directories(string path)
        {
            this.path = path;
        }

        public void Copy()
        {
            throw new NotImplementedException();
        }
       

      

        public void Info()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Open() //Открытие папки означает получение всех файлов и папок внутри нее
        {
            ls = new Dictionary<int, string>();

            try
            {

                string[] folders = Directory.GetDirectories(path); //Загружаем в массив список всех подкаталогов данного каталога
                
                string[] files = Directory.GetFiles(path); //И файлы
                
                foreach (string folder in folders) //Для каждой папки в массиве папок
                {
                    ls.Add(i++,folder); //Добавить в список каталог
                                    //ls.AddRange(GetRecursFiles(folder)); //Тут получается будут все подкаталоги каталога наверху          

                }
                foreach (string fileName in files) //в конце того же списка будут и файлы
                {
                    ls.Add(i++,fileName);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Файлы открывать не умею");
            }
            foreach (int s in ls.Keys)
            {
                Console.WriteLine( s + ")" + ls[s]);                
            }

        }

        public void Rename()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        public double Size()
        {
            throw new NotImplementedException();
        }

        List<string> Close()
        {
            throw new NotImplementedException();
        }

    }
}
