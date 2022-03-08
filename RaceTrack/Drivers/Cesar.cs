using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Cesar : Driver
    {
        public Cesar(RaceCar car) : base(car)
        {
            Name = "Cesar";
            SkillLevel = 9;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}