using System;
namespace StudentCarGame
{
    public class Truck : TrafficCar
    {

        public Truck(int damage, int cash)
        {
            Damage = damage;
            Cash = cash;
            Name = "Truck";
        }

        public override void OnCollision(GameObject other)
        {

        }
    }
}
