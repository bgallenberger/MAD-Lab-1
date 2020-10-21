using System;
using System.Collections.Generic;
using System.Text;

namespace MAD_Lab_1
{
    public abstract class Person
    {
        protected String name { get; set; }

        public Person(String name)
        {
            this.name = name;
        }
    }
}
