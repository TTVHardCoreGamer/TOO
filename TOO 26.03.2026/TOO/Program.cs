namespace TOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.Name = "BMW";
            vehicle.Speed = 120;

            Vehicle vehicle1 = new Bicycle();
            vehicle1.Name = "Trek";
            vehicle1.Speed = 20;

            vehicle.Describe();
            vehicle1.Describe();
        }
    }
}
