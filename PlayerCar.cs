using System;
namespace StudentCarGame
{
    public abstract class PlayerCar
    {
        public string Name { get; }
        public int Handling { get; }
        public int TopSpeed { get; }
        public int Strength { get; }

        

        public PlayerCar(string name, int handling, int topSpeed, int strength)
        {
            Name = name;
            Handling = handling;
            TopSpeed = topSpeed;
            Strength = strength;
        }

        public abstract void Accelerate();
        public abstract void Brake();
        public abstract void MoveLeft();
        public abstract void MoveRight();
    }
}
