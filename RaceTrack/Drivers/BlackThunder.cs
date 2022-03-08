using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BlackThunder : Driver
    {
        public BlackThunder(RaceCar car) : base(car)
        {
            Name = "BlackThunder";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}