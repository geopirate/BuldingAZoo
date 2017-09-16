using System;

namespace Zoo
{
    // child class level 3
    class Wildcat : Felidae
    {
        public void WildcatIntro() => Console.WriteLine(
            "I'm  a Wildcat!");
        public void HouseCat() => Console.WriteLine(
            "Wildcats are very similar to modern house cats.");
        override public void MyHabitat() => Console.WriteLine(
            "I live in tree hollows and sometimes burows of other animals.");
    }
}
