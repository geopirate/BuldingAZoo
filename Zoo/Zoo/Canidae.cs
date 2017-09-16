using System;


namespace Zoo
{
    abstract class Canidae : Carnivora
    {
        override public void SubOrderName() => Console.WriteLine(
            "The suborder Canidae covers many dog like mammals.");
        public abstract void Diet();
        public abstract void MyDiet();
    }
}
