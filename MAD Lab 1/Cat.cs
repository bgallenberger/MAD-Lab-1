using System;
using System.Collections.Generic;
using System.Text;

namespace MAD_Lab_1
{
    class Cat : Pet, Talkable  
    {
        private int mousesKilled { get; set; }

        public Cat(int mousesKilled, String name) : base(name)
        {
            this.mousesKilled = mousesKilled;
        }
        public void AddMouse()
        {
            mousesKilled++;
        }
        public String Talk()
        {
            return "Meow";
        }
        public String GetName()
        {
            return "Dog: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}
