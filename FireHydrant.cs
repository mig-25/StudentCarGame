using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCarGame
{
    public class FireHydrant : SideObject
    {
        

        public FireHydrant(int damage, int cash)
        {
            Damage = damage;
            Cash = cash;
            Name = "FireHydrant";
        }

        public override void OnCollision(GameObject other)
        {
            base.OnCollision(other);
        }
    }
}
