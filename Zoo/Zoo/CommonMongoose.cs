using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // child class level 3
    class CommonMongoose : Herpestidae
    {
        public void MongoosetIntro() => Console.WriteLine(
            "I'm  a Common Mongoose!");
        public void SnakeFighter() => Console.WriteLine(
            "They are known for fighting venomous snakes.");
        public override void Social() => Console.WriteLine(
            "They aren't very social and are usually found alone or in pairs.");
    }
}
