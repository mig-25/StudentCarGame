using System;
namespace StudentCarGame
{
    public class Sedan : TrafficCar
    {
        
        public Sedan(int damage, int cash)
        {
            Damage = damage;
            Cash = cash;
            Name = "Sedan";
        }

        
        public override void OnCollision(GameObject other)
        {

        }

    }
}
