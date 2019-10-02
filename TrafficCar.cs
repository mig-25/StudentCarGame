using System;
namespace StudentCarGame
{
    /*
     The TraficCar inherits from the parent class GameObject.
     */
    public abstract class TrafficCar : GameObject
    {
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Cash { get; set; }



        /*
         Crate a constructor with following arguments
         If the parent class hade it constructor, then we have to implement the
         arguments from that parent class constructor too.
         For example:
         //public TrafficCar(int damage, int speed, int cash) : base (enb, name, tag)
         */
        //public TrafficCar(int damage, int cash)
        //{
        //    Damage = damage;
        //    Cash = cash;
        //}

        /*
         TrafficCar inerits from GameObject and could implement the OnCollision
         method, but TraficCar itself has children in form other types of
         vehicles, and its in this specific child classes we will implement the
         OnCollision method.
         For example the Sedan child class will show sparks when collided with,
         but if we collide with a Truck, we can show logs fall of.
         */

        public static TrafficCar Create()
        {
            Random r = new Random();
        }
    }
}
