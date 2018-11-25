using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTools
{
    public abstract class Box
    {
        public uint Length { get; set; }
        public uint Width { get; set; }
        public uint Hight { get; set; }
        public uint Weight { get; set; }
        public abstract string AlarmMessage();
        public abstract string MessageaboutWeight();

    }
    public class Handluggage : Box
    {
        const uint maxmeasure = 115; // максимальное значение суммы трех измерений 
        const uint maxweight  = 10;   // ограничение по весу
        public Handluggage(uint Lenght, uint Widht, uint Hight, uint Weight)
        {   this.Length = Lenght;
            this.Width  = Widht;
            this.Hight  = Hight;
            this.Weight = Weight;
        }
         
        public override string AlarmMessage()
        {
            if (Length + Width + Hight > maxmeasure)
                 return "Объект не продходит как ручная кладь";
            else return "Ручная кладь";

        }
        public override string MessageaboutWeight()
        {
            if (Weight > maxweight)
                 return "Есть перевес, необходима оплата";
            else return "Вес соответствует";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Handluggage luggage1 = new Handluggage(12, 34, 56, 3);
            Console.WriteLine(luggage1.AlarmMessage());
            Console.WriteLine(luggage1.MessageaboutWeight()+"\r\n");
           
            Handluggage luggage2 = new Handluggage(112, 4, 56, 3);
            Console.WriteLine(luggage2.AlarmMessage());
            Console.WriteLine(luggage2.MessageaboutWeight() + "\r\n");

            Handluggage luggage3 = new Handluggage(12, 34, 56, 12);
            Console.WriteLine(luggage3.AlarmMessage());
            Console.WriteLine(luggage3.MessageaboutWeight() + "\r\n");

            Handluggage luggage4 = new Handluggage(111, 4, 6, 12);
            Console.WriteLine(luggage4.AlarmMessage());
            Console.WriteLine(luggage4.MessageaboutWeight() + "\r\n");

            Console.ReadKey();
        }
    }
}





