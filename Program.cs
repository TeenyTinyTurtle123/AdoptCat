using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    static List<Cat> catList = new(); // making a list that will store information from the Cat class
    private static void Main(string[] args)
    {
        while (true)
        {

            Console.Clear();

            Meny();                          // the meny is shown and the users input will be stored
            string input = Console.ReadLine();// into the string 'input'



            if (input.ToUpper() == "Q") // making a smal 'q' turn turn into a lagre 'Q'
            {                           // and quitting the loop
                System.Console.WriteLine("See you again!");
                Environment.Exit(0);
            }
            else if (input == "1") // if the user presses '1', the AddCat method will be activated
            {
                AddCat();
            }
            else if (input == "2")
            {
                ShowCats();
            }
            else if (input == "4")
            {
                ClearCats();
            }


        }
    }

    static void Meny() // This is the meny
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
    static void AddCat() // the metod to add a cat.
    {
        System.Console.WriteLine("What's the cat's name?: ");//  We start by asking/adding the name in a varible
        string catName = Console.ReadLine();

        System.Console.WriteLine("What colour is the cat?: ");// asking/adding the colour in a varible
        string catColour = Console.ReadLine();

        System.Console.WriteLine("And how old is the cat?"); // asking their age. 
        if (int.TryParse(Console.ReadLine(), out int catAge)) // we use int.TryParse to try and make the answer into an int-varible
        {                                                    // if it works, it will be given the varible catAge
            Cat newCat = new Cat(catName, catColour, catAge); // and if everything works, all information -
            catList.Add(newCat); // - will be added into the catList, as newCat
            System.Console.WriteLine("We have registrated you cat!");

            Console.ReadKey();

        }

    }
    static void ShowCats()
    {

        foreach (Cat cat in catList)
        {
            cat.CatInfo(); // I'm using a foreach loop to list all the added cats, by using the method
        }                  // CatInfo that I made in the Cat class
        Console.ReadKey();
    }
    static void ClearCats()
    {
        catList.Clear(); // this clear the catList-list
        System.Console.WriteLine("All Cats have been moved to another location!");
    }
    class Cat // creating the Cat class
    {
        public string Name; // givin the varibels/ information we want to store
        public string Colour;
        public int Age;
        public Cat(string name, string colour, int age) // a constructor
        {
            Name = name;
            Colour = colour;
            Age = age;

        }
        public void CatInfo() // a method that will use the information to print this out
        {
            System.Console.WriteLine("This is " + Name + ", they are a " + Age + " year old " + Colour + " happy cat!");
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