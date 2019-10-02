using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentCarGame
{
    

    public class GameObject

    {
        /*
         A property in C# is a way to set getters and setters for private
         attributes
         */
        //Enabling or disabling a game object
        private bool Enabled { get; set; }
        //identify game object
        public String Name { get; set; }
        /*identify a group of game objects, like trafic cars, to group all
        trafic vehicles like trucks, buses, milkvan or sedan
        */
        public String Tag { get; set; }

        /*
        //Normal way to use getters and setters in C#
        public bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
            }

        }
        */

        /*
         This method is declared as virtual, and must therefore be public.
         The virutal keyword also means that the implemention of this method
         will be done in the child classes.
         This method takes another GameObject as a argument. GameObject is a
         datatype here. The argument GameObject will be the instance of the GameObect
         with wich this current GameObject has collided with.
         The child classes will each implement their own behavior with the
         keyword overide.
         The reason why we have declared this method as virtual and not as
         abstart is because we might have some GameObjects that dont need to
         implement the onCollision method, trees or houses. If this it was a
         abtract method, then they must implement this method reglardless.
         Otherwise the whole child class becomes as a abstact class.
         */
        public virtual void OnCollision(GameObject other)
        {

        }

        public static void CheckEnabled()
        {
            GameObject go = new GameObject();
            go.Enabled = true; //Setter method
            bool e = go.Enabled; //Getter method
        }
    }
}
