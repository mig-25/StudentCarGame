using System;
namespace StudentCarGame
{
    public class PostBox :  SideObject
    {
        public PostBox(int damage, int cash)
        {
            Damage = damage;
            Cash = cash;
            Name = "Postbox";
        }

        public override void OnCollision(GameObject other)
        {

        }

        public override void OnEnabled()
        {
            count = 0;
        }
    }
}
