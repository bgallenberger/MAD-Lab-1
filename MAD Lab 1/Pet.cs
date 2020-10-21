using System;
using System.Collections.Generic;
using System.Text;

namespace MAD_Lab_1
{
    public abstract class Pet
    {
        protected String name { get;}

        public Pet(String name)
        {
            this.name = name;
        }
    }
}
