using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean multiSet = false;
            int people = 0;
            int donuts = 0;
            //puts every line of the .txt files into a string array
            string[] regDonuts = System.IO.File.ReadAllLines(@"D:\Users\temp.MOO\Source\Repos\C-RandomStuff\DonutFinder\DonutFinder\Donuts.txt");
            string[] expreDonuts = System.IO.File.ReadAllLines(@"D:\Users\temp.MOO\Source\Repos\C-RandomStuff\DonutFinder\DonutFinder\ExpressionDonuts.txt");
            //ask the user if they want it in random sets (do you want everyone to have the same random donuts?)
            Console.WriteLine("Are you serving multiple people with these donuts? If so, do you want everyone to get the same random set of donuts?");
            String in1 = Console.ReadLine();
            in1 = in1.ToLower();
            if(in1.Contains("yes"))
            {
                multiSet = true;
            Inquiry1:
                Console.WriteLine("How many donuts do you want each person to recieve?");
                string tmp = Console.ReadLine();
                if(Int32.TryParse(tmp, out donuts))
                {
                Inquiry2:
                    Console.WriteLine("OK. You want each person to get " + donuts + " donuts. How many people will there be for this rad party?!?");
                    tmp = Console.ReadLine();
                    people = 0;
                    if(Int32.TryParse(tmp, out people))
                    {
                        int tmpDonuts = donuts * people;
                        Console.WriteLine("This means that you want to order " + tmpDonuts + " donuts? Fine by me.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry. I didn't quite get that. Try again please.");
                        goto Inquiry2;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry. I didn't quite get that. Try again please.");
                    goto Inquiry1;
                }
            }
            else
            {
                Console.WriteLine("OK then. All for yourself. Sounds good.");
            Inquiry3:
                Console.WriteLine("How many circles of wonder do you want?");
                string tmp = Console.ReadLine();
                if(Int32.TryParse(tmp, out donuts))
                {
                    Console.WriteLine("Allrighty! I will now generate a list of " + donuts + " random Krispy Kreme donuts!");
                    Console.WriteLine("GENERATING!");
                    Random rnd = new Random();
                    for (int i = 0; i <= donuts; i++)
                    {
                        System.IO.File.WriteAllText(@"D:\Users\temp.MOO\Source\Repos\C-RandomStuff\DonutFinder\DonutFinder\OutputDonuts.txt", regDonuts[rnd.Next(donuts)]);
                    }
                    Console.WriteLine("Donut generation complete. Would you like to see the list of donuts?");
                }
                else
                {
                    Console.WriteLine("Sorry. I didn't quite get that. Try again please.");
                    goto Inquiry3;
                }
            }

            //if yes, then ask how many donuts, and how many per person

            //if no, then ask how many donuts
            //load donut list from txt file
            //determine how many donuts were loaded, build string array
            //random number from 1->amount of donuts
            //print out corresponding donuts in array
            //email output to end user
        }
    }
}
