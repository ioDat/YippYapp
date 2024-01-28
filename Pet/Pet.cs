using System;
using System.Collections.Generic;

namespace Pet
{
    public class Pet
    {
        protected string name { get; }
        protected string noise { get; set; }
        protected string trick { get; set; }

        public Pet(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTrick()
        {
            return trick;
        }

        public string GetNoise()
        {
            return noise;
        }
    }

    public class Dog : Pet
    {
        public Dog(string name) : base(name)
        {
            trick = "fetch";
            noise = "voff";
        }
    }

    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
            trick = "backflip";
            noise = "mjauu";
        }
    }

    public class Fish : Pet
    {
        public Fish(string name) : base(name)
        {
            trick = "Blow Bubblez";
            noise = "blub blub";
        }
    }
}