using System;
namespace StudentCarGame
{
    public class PlayerSedan:PlayerCar
    {
        public PlayerSedan(string name, int handling, int topSpeed, int strength):base(name, handling, topSpeed, strength)
        {
        }

        public override void Accelerate()
        {
            Console.WriteLine("Accelrating!!!");
        }

        public override void Brake()
        {
            Console.WriteLine("Breaking!!!");
        }

        public override void MoveLeft()
        {
            Console.WriteLine("Turn left");
        }

        public override void MoveRight()
        {
            Console.WriteLine("Turn right");
        }
    }
}
