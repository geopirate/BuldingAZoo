using System;

namespace Zoo
{
    // grandchild class
    class Wildcat : Felidae
    {
        override public void CommonName() => Console.WriteLine(
            "I'm  a Wildcat!");
        override public void MyHabitat() => Console.WriteLine(
            "I live in tree hollows and sometimes burows of other animals.");
    }
}
