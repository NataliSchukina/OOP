using System;

namespace AppTools
{
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





