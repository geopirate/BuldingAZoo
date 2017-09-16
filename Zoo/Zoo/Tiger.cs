using System;

namespace Zoo
{
    // grandchild class
    class Tiger : Felidae
    {
        override public void CommonName() => Console.WriteLine(
            "I'm  a tiger!");
        override public void MyHabitat() => Console.WriteLine(
            "I actually mostly live in a cave or den.");
    }
}
