namespace TOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone();
            p.Name = "Iphone";
            p.TurnOn();
            p.Call();

            SmartWatch w = new SmartWatch();
            w.Name = "Garmin";
            w.TurnOn();
            w.ShowTime();
        }
    }
}
