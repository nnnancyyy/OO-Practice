namespace OOPractice
{
    public class Vehicle
    {
        public Vehicle(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
        public int Speed(string type)
        {
            if (type == "oil")
            {
                return 30;
            }

            return 10;
        }

        public string SpeedUp()
        {
            return Name + ": speed up to " + Speed(Type).ToString() + " km/h";
        }
    }
}