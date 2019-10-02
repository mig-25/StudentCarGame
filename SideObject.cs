using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentCarGame
{
    public abstract class SideObject : GameObject
    {
        public int Damage { get; protected set; }
        public int Cash { get; protected set; }
        /*Keep acount of how many times the side object is hit, as we only show
         the onCollision behavior once, just accumalate more cash to player
         account, to keep track how much cash we take the value of count
         */
        protected int count = 0;

        public static SideObject Create()
        {
            Random r = new Random();
            SideObject sideObj = null;
        }

    }
}
