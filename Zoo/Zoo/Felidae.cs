using System;

namespace Zoo
{
    // child class #1
    abstract class Felidae : Carnivora
    {
        override public void SubOrderName() => Console.WriteLine(
            "The suborder Felidae covers many cat like mammals.");
        public void Habitat() => Console.WriteLine(
            "Cats tend to be arboreal, meaning we live in trees.");
        public abstract void MyHabitat();
    }
}
