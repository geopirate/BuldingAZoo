using System;

namespace Zoo
{
    // child class level 1
    abstract class Feliformia : Carnivora
    {
        public override sealed void SubOrderName() => Console.WriteLine(
            "The suborder Feliformia covers many cat like species of mammals.");
        public void Legs() => Console.WriteLine("All of these animals have 4 legs.");
        public abstract void FamilyName();
    }
}
