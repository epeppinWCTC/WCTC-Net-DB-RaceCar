using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class Chariot : RaceCar
    {
        public Chariot()
        {
            Name = "Chariot";
            TopSpeed = 20;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} gallops to the starting line!");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} gallops to a stop");
        }
    }
}