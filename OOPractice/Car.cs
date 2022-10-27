using System;

namespace OOPractice
{
    public class Car
    {
        public Car(string name, int speed)
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