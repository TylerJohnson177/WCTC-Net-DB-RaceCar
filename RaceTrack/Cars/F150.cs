using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class F150 : RaceCar
    {
        public F150()
        {
            Name = "F150";
            TopSpeed = 95;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} fires up");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} grinds to a halt");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}s engine turns off");
        }
    }
}