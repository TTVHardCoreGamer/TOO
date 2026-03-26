namespace TOO
{
    class Vehicle
    {
        public int Speed;
        public string Name;
    
        public virtual void Describe()
        {
            Console.WriteLine("This is a vehicle ");
        }
    }
}

