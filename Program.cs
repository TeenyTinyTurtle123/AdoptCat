using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    static List<Cat> catList = new();
    private static void Main(string[] args)
    {
        while (true)
        {
            // Cat newCat = new Cat();

            Console.Clear();

            Meny();
            string input = Console.ReadLine();



            if (input.ToUpper() == "Q")
            {
                System.Console.WriteLine("See you again");
                Environment.Exit(0);
            }
            else if (input == "1")
            {
                AddCat();
            }




        }
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

    }
    static void AddCat()
    {
        System.Console.WriteLine("What's the cat's name?: ");
        string catName = Console.ReadLine();

        System.Console.WriteLine("What colour is the cat?: ");
        string catColour = Console.ReadLine();

        System.Console.WriteLine("And how old is the cat!");
        if (int.TryParse(Console.ReadLine(), out int catAge))
        {
            Cat newCat = new Cat(catName, catColour, catAge);
            catList.Add(newCat);
            System.Console.WriteLine("We have registrated you cat?");

            Console.ReadKey();

        }

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
        public Cat(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;

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