using System;

namespace Zoo
{
    // child class level 3
    class Tiger : Felidae
    {
        public void TigerIntro() => Console.WriteLine(
            "I'm  a tiger!");
        public void Population() => Console.WriteLine(
            "There are less than 3000 tigers left in the wild.");
        override public void MyHabitat() => Console.WriteLine(
            "I actually mostly live in a cave or den.");
    }
}
