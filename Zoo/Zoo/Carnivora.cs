using System;

namespace Zoo
{
    // this is the bass class
    abstract class Carnivora
    {
        public void OrderName() => Console.WriteLine(
            "The order Carnivora covers many species of mamamals that tend to largely eat meat");
        public void Fur() => Console.WriteLine(
            "We are all covered in fur.");
        public abstract void SubOrderName();
        public abstract void CommonName();
    }
}
