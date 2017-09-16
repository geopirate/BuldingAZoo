using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Wildcat wildcat = new Wildcat();
            Cats(tiger);
            Cats(wildcat);

            Console.Read();
        }

        private static void Cats(Felidae cat)
        {
            cat.CommonName();
            cat.SubOrderName();
            cat.OrderName();
            cat.Fur();
            cat.Habitat();
            cat.MyHabitat();
            Console.WriteLine();
        }

        /*private static void Cats(Felidae cat)
        {
            cat.CommonName();
            cat.SubOrderName();
            cat.OrderName();
            cat.Fur();
            cat.Habitat();
            cat.MyHabitat();
            Console.WriteLine();
        }

        private static void Cats(Felidae cat)
        {
            cat.CommonName();
            cat.SubOrderName();
            cat.OrderName();
            cat.Fur();
            cat.Habitat();
            cat.MyHabitat();
            Console.WriteLine();
        }*/
        // Wolf
        // Fox
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
