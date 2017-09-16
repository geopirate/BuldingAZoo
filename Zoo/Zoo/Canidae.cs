using System;


namespace Zoo
{
    // child class level 1
    abstract class Canidae : Carnivora
    {
        override public void SubOrderName() => Console.WriteLine(
            "The suborder Canidae covers many dog like mammals.");
        public abstract void Diet();
        public abstract void MyDiet();
        public static void legs() => Console.WriteLine("All of these animals have 4 legs.");
    }
}
