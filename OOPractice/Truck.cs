namespace OOPractice
{
    public class Truck
    {
        public Truck(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Name { get; }
        public int Speed { get; }

        public string SpeedUp()
        {
            return Name + ": speed up to " + Speed + " km/h";
        }
    }
}