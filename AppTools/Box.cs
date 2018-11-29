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
}
