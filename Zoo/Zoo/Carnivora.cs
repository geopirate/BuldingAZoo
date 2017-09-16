using System;

namespace Zoo
{
    // this is the bass class
    abstract class Carnivora
    {
        public void OrderName() => Console.WriteLine(
            "The order Carnivora covers many species of mamamals that tend to largely eat meat");
        public virtual void Fur() => Console.WriteLine(
            "We are all covered in fur.");
        public abstract void SubOrderName();
    }
}
