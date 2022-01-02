using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Building
    {
        static int ID; //Генератор уникального номера
        
        int high; //высота здания
        int stage; //Количество этажей
        int apartment; //Количество квартир 
        int porch; //Количество подъездов

        public Building()
        {
            ID ++;            
        }
        public int High
        { 
            get 
            { 
                return high; 
            } 
            set 
            { 
                high = value; 
            } 
        }
        public int Stage
        {
            get
            {
                return stage;
            }
            set
            {
                stage = value;
            }
        }
        public int Apartment
        {
            get 
            { 
                return apartment; 
            }
            set 
            { 
                apartment = value; 
            }
        }
        public int Porch
        {
            get 
            { 
                return porch; 
            } 
            set 
            { 
                porch = value; 
            }
        }

        public int Number
        {
            get
            {
                return ID;
            }
        }
       

        public double StageHigh ()
        {
            return high / stage;
        }

        public int PorchApartment() //Надо иметь в виду, что был бы логичнее через количество подъездов и этажей вычислит общее количество квартир. А при данных обстоятельствах 
            //результаты вычисления могут быть не правдоподобны 
        {
            return apartment / porch;
        }

        public int ApartmentStage ()
        {
            return PorchApartment() / stage;
        }

        public void Adress (int apartment)
        {
            int stage = (apartment % PorchApartment())/ApartmentStage ();
            int porch = apartment / PorchApartment();
            if (apartment % PorchApartment() == 0)
            {
                Console.WriteLine($"последняя квартира {porch} подъезда");
            }
            else if ((apartment % PorchApartment()) % ApartmentStage() == 0)
            {
                Console.WriteLine($"{porch+1} подъезд, {stage} этаж");
            }
            else
            {
                Console.WriteLine($"{porch + 1} подъезд, {stage+1} этаж");
            }
        }
    }
}
