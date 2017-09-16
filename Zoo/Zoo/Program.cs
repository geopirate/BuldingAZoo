using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.TigerIntro();
            
            //inherited from base class
            tiger.OrderName();
            tiger.Fur();
            
            // inherited from 1st level
            tiger.SubOrderName();
            tiger.Legs();

            // inherited from 2nd level
            tiger.FamilyName();
            tiger.Habitat();
            // overridden from parent
            tiger.MyHabitat();

            tiger.Population();
            Console.WriteLine();


            Wildcat wildcat = new Wildcat();
            wildcat.WildcatIntro();
            
            //inherited from base class
            wildcat.OrderName();
            wildcat.Fur();
            
            // inherited from 1st level
            wildcat.SubOrderName();
            wildcat.Legs();
            
            // inherited from 2nd level
            wildcat.FamilyName();
            wildcat.Habitat();
            // overridden from parent
            wildcat.MyHabitat();

            wildcat.HouseCat();
            Console.WriteLine();

            CommonMongoose mongoose = new CommonMongoose();
            mongoose.MongoosetIntro();

            //inherited from base class
            mongoose.OrderName();
            mongoose.Fur();

            // inherited from 1st level
            mongoose.SubOrderName();
            mongoose.Legs();

            // inherited from 2nd level
            mongoose.FamilyName();
            mongoose.Venom();
            // overridden from parent
            mongoose.Social();

            mongoose.SnakeFighter();
            Console.WriteLine();


            Meerkat meerkat = new Meerkat();
            meerkat.MeerkatIntro();

            //inherited from base class
            meerkat.OrderName();
            meerkat.Fur();

            // inherited from 1st level
            meerkat.SubOrderName();
            meerkat.Legs();

            // inherited from 2nd level
            meerkat.FamilyName();
            meerkat.Venom();
            // overridden from parent
            meerkat.Social();

            meerkat.NotMongoose();
            Console.WriteLine();

            Console.Read();
        }
    }
}
/*
Directions

Using the Object Oriented Principles (OOPs) you learned today (Inhertiance and Abstraction)
Build out the hierarchical class structure of a zoo. There should be at least 3 layers of inheritance with at least 6 different types of animals.
Show inheritance by using Console.WriteLine() as neccesary to prove that a methods were propertly implemented or inherited. 
Examples include: Eat() Sleep() Sound() etc...
You are allowed to use these example methods, along with others not listed
Be sure to include a diagram with your solution of how your zoo is mapped out.
Label the abstract methods and classes as neccesary and be sure to clearly show the inheritance levels.

Components

Have at least 3 different abstract classes
Have at least 3 layers of inheritance
Have at least 3 abstract methods (each in different classes)
Each class you define should have at least 3 methods in it.
Your drawing of your zoo diagram should be clearly labeled of which classes
To 'prove' your inheritance, use Console.WriteLine() to output to the console.
 */
