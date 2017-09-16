using System;

namespace Zoo
{
    // child class level 2
    abstract class Herpestidae : Feliformia
    {
        override public void FamilyName() => Console.WriteLine(
            "The family Herpestidae is also known as Mongoose");
        public void Venom() => Console.WriteLine(
            "They are evolved to be immune to snake venom");
        public abstract void Social();
    }
}
