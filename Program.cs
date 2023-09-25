using System;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    List<Cat> catList = new();
    private static void Main(string[] args)
    {
        Console.Clear();

        Meny();



    }
    static void Meny()
    {
        System.Console.WriteLine("Welcoms! This is the Cat registrater!");
        System.Console.WriteLine("What will you be doing today?: ");
        System.Console.WriteLine("1. Adding a new cat");
        System.Console.WriteLine("2. View the register");
        System.Console.WriteLine("3. Select a cat to take home");
        System.Console.WriteLine("4. Clear the register");
        System.Console.WriteLine("Q. Quit the meny");
        System.Console.Write("> ");

        string input = Console.ReadLine();
    }
    class Cat
    {
        public string Name;
        public string Colour;
        public int Age;
        public void CatInfo()
        {
            System.Console.WriteLine("This is " + Name + " the are a " + Age + " year old " + Colour + " happy cat!");
        }

        public void Food()
        {
            if (Age <= 2)
            {
                System.Console.WriteLine("This cat need 2 fish a day!");
            }
            else if (Age <= 4)
            {
                System.Console.WriteLine("This cat needs 3 fish a day!");
            }
            else if (Age <= 10)
            {
                System.Console.WriteLine("This cat needs 4 fish a day!");
            }
            else if (Age > 11)
            {
                System.Console.WriteLine("Just give the cat all the fish you have!");
            }
        }
    }
}