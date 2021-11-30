using System;
using System.Collections.Generic;


namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(10);
            firstNames();
        }
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] randomInt = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomInt[i] = rand.Next(5,25);
            }
            foreach(int random in randomInt )
            {
                Console.WriteLine(random);
            }

            int min = randomInt[0];
            int max = randomInt[0];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if(randomInt[i] > max)
                {
                    max = randomInt[i];
                }
                else if (randomInt[i] < min)
                {
                    min = randomInt[i];
                }
                sum += randomInt[i];
            }
                Console.WriteLine("Max:" + max);
                Console.WriteLine("Min:" + min);
                Console.WriteLine("Sum:" + sum);
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            int coinFlip = rand.Next(2);
            if (coinFlip == 1)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else 
            {
                Console.WriteLine("Tails");
                return "Tails";
            }

        }
        public static double TossMultipleCoins(int num)
        {
            double heads_ratio = 0;
            for (int i =0; i <num; i++)
            {
                if(TossCoin() == "Heads")
                {
                    heads_ratio +=1;
                }
            }
            heads_ratio = heads_ratio/ num;
            Console.WriteLine(heads_ratio);
            return heads_ratio;
        }

        public static List<string> firstNames()
        {
            List<string> names = new List<string> ();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            Random rand = new Random();
            for(int i = 0; i < names.Count; i++)
            {
                int random = rand.Next(i + 1);
                string value = names[random];
                names[random] = names[i];
                names[i] = value;

            }
            for (int i = 0; i <names.Count; i++)
            {
                if(names[i].Length <5)
                {
                    names.Remove(names[i]);
                }
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            return names;
        }
    }
}