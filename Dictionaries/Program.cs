using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Dictionary Syntax
            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix" },
            //    { "A2", "Twizzlers" },
            //    {"A3", "Reeses" },
            //    {"A4","Sour Patch Kids" }
            //};
            //foreach (KeyValuePair<string, string> item in snackMachine)
            //{
            //    //Console.WriteLine(item);
            //}
            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew");

            ////Console.WriteLine(drinkMachine.Count);
            //foreach (KeyValuePair<int,string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}

            //Theater coat check  with 10 elements
            //Key = Number, Value = CoatStyle
            //Print elements to the console
            //Dictionary<int, string> coatCheck = new Dictionary<int, string>
            //{
            //    {1,"Leather Jacket" }, {2,"Trench Coat" }, {3,"Baseball Jacket" }, {4, "Windbreaker" }, {5,"Hoodie" },
            //    {6,"Bomber Jacket" }, {7,"Blue Trench Coat" }, {8,"Red Baseball Jacket" }, {9, "Yellow Windbreaker" }, {10,"Gray Hoodie" }
            //};
            //foreach (KeyValuePair<int,string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat.Key);
            //    Console.WriteLine(coat.Value);
            //}

            ////Car valet with 10 cars
            ////key = last name, value = car name
            ////Print elements to the console
            //Dictionary<string, string> valet = new Dictionary<string, string>
            //{
            //    { "anderson","volvo"}, { "jones", "bmw"}, { "alvarado","corvette"}, {"james","hyundai" }, {"rivera","beetle" },
            //     { "rodriguez","jaguar"}, { "hallmann", "subaru"}, { "alvarez","honda"}, {"morales","ford" }, {"rivers","jeep" }
            //};
            //foreach (KeyValuePair<string,string> car in valet)
            //{
            //    Console.WriteLine(valet.Keys);
            //    Console.WriteLine(valet.Values);
            //}


            //Zoo with 10 animals
            //key = animal type, value = number of animals
            //Print elements with the highest quantity to the console
            //Remove the animal with the lowest quantity
            Dictionary<string, int> zoo = new Dictionary<string, int>()
            {
                {"polar bear", 3 }, {"monkey",8 }, {"iguana", 15 }, {"brown bear", 4 }, {"hippo",1 },
                { "wolf",8 }, { "elephant", 4}, { "giraffe", 5}, { "camel", 8}, {"lion",6 }
            };
            foreach (KeyValuePair<string, int> animal in zoo)
            {
                Console.WriteLine(animal.Key + ": " + animal.Value);
            }
            int high = 0;
            string zooAnimal = "";
            int low = 100;
            string removeAnimal = "";
            foreach (KeyValuePair<string,int> animal in zoo)
            {
                if(animal.Value > high)
                {
                    high = animal.Value;
                    zooAnimal = animal.Key;
                }
            }
            Console.WriteLine();
            Console.WriteLine(zooAnimal + ": " + high);
            Console.WriteLine();

            foreach(KeyValuePair<string, int> animal in zoo)
            {
                if(animal.Value <low)
                {
                    low = animal.Value;
                    removeAnimal = animal.Key;
                }
            }
            zoo.Remove(removeAnimal);
            foreach (KeyValuePair<string, int> animal in zoo)
            {
                Console.WriteLine(animal.Key + ": " + animal.Value);
            }
        }
    }
}
