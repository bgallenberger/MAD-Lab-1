using System;
using System.IO;
using System.Collections.Generic;

namespace MAD_Lab_1
{
    class Program
    {
        private static FileOutput outFile = new FileOutput(@"..\..\..\animals.txt");
        static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();

            var userInput = "";
            while (String.IsNullOrEmpty(userInput) || (userInput != "1" && userInput != "2"))
            {
                Console.WriteLine("What type of animal would you like to add? \n1) Dog \n2) Cat");
                userInput = Console.ReadLine();
            }

            if(userInput == "1")
            {
                Console.Write("Name of Dog: ");
                var dogName = Console.ReadLine();

                var dogFriend = "";
                while (String.IsNullOrEmpty(dogFriend) || (dogFriend.ToLower() != "y" && dogFriend.ToLower() != "n"))
                {
                    Console.Write("Is the Dog Friendly (Y)/(N): ");
                    dogFriend = Console.ReadLine();
                }
                var isFriendly = dogFriend == "y" ? true : false;
                zoo.Add(new Dog(isFriendly, dogName));
            }
            else
            {
                Console.Write("Name of Cat: ");
                var catName = Console.ReadLine();

                var isNumeric = false;
                var mouseKills = "";
                while (!(isNumeric = int.TryParse(mouseKills, out _)))
                {
                    Console.Write("Number of Mouse Kills: ");
                    mouseKills = Console.ReadLine();
                }
                zoo.Add(new Cat(int.Parse(mouseKills), catName));
            }

            foreach (Talkable thing in zoo)
            {
                PrintOut(thing);
            }
            outFile.FileClose();

            FileInput inFile = new FileInput(@"..\..\..\animals.txt");
            inFile.FileRead();
            inFile.FileClose();

            FileInput indata = new FileInput(@"..\..\..\animals.txt");
            String line;
            while ((line = indata.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        public static void PrintOut(Talkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            outFile.FileWrite(p.GetName() + " | " + p.Talk());
        }
    }
}
