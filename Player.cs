using System;
namespace StudentCarGame
{
    public class Player:GameObject
    {
        public PlayerCar Car { get; set; }
        public int Health { get; set; }

        //read only property

        /*
        public bool IsAlive
        {
            get
            {
                return Health < 0;
            }
        }
        */

        public bool IsAlive
        {
            get;
            set;
        }

        public Player()
        {
            Health = 100;
            IsAlive = true;
        }

        public void OnUp()
        {
            Car.Accelerate();
        }

        public void OnDown()
        {
            Car.Brake();
        }

        public void OnLeft()
        {
            Car.MoveLeft();
        }

        public void OnRight()
        {
            Car.MoveRight();
        }

        public void ApplyDamage(int damage, int cash)
        {
            Health -= damage - Car.Strength;

            Console.WriteLine("[Player] Health:{0}", Health);

            //GameManager.Instance.AddPlayerCash(cash);
            //if (Health <= 0)
            //{
            //    IsAlive = false;
            //}
        }
    }
}
