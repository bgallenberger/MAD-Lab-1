using System;
using System.Collections.Generic;
using System.Text;

namespace MAD_Lab_1
{
    class Dog : Pet, Talkable
    {
        private bool friendly { get; set; }

        public Dog(bool friendly, String name) : base(name)
        {
            this.friendly = friendly;
        }
        public String Talk()
        {
            return "Bark";
        }
        public String GetName()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}
