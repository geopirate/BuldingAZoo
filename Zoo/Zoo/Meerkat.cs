using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // child class level 3
    class Meerkat : Herpestidae
    {
        public void MeerkatIntro() => Console.WriteLine(
            "I'm  a Meerkat!");
        public void NotMongoose() => Console.WriteLine(
            "Meerkats one of the few non-Mongoose in the family.");
        public override void Social() => Console.WriteLine(
            "Meerkats are extremely social and even groom each other!");
    }
}
