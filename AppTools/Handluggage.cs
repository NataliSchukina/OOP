namespace AppTools
{
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
}





