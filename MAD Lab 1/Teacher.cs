using System;
using System.Collections.Generic;
using System.Text;

namespace MAD_Lab_1
{
    class Teacher : Person, Talkable
    {
        private int age { get; set; }

        public Teacher(int age, String name) : base(name)
        {
            this.age = age;
        }

        public String Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
        public String GetName()
        {
            return name;
        }
    }
}
