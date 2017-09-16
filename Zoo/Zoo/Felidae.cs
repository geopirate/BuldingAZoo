using System;

namespace Zoo
{
    // child class level 2
    abstract class Felidae : Feliformia
    {
        override public void FamilyName() => Console.WriteLine(
            "The family Felidae covers many cat like mammals.");
        public void Habitat() => Console.WriteLine(
            "Cats tend to be arboreal, meaning they live in or around trees.");
        public abstract void MyHabitat();
    }
}
