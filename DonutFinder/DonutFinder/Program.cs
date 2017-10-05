using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DonutFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean multiSet = false;
            int people = 0;
            int donuts = 0;
            string tmp2 = "1";
            //puts every line of the .txt files into a string array
            string regDonutsPath = @"D:\Users\temp.MOO\Source\Repos\C-RandomStuff\DonutFinder\DonutFinder\Donuts.txt";
            string expreDonutsPath = @"D:\Users\temp.MOO\Source\Repos\C-RandomStuff\DonutFinder\DonutFinder\ExpressionDonuts.txt";
            string outputDonutsPath = @"D:\Users\temp.MOO\Source\Repos\C-RandomStuff\DonutFinder\DonutFinder\OutputDonuts.txt";
            string[] regDonuts = System.IO.File.ReadAllLines(regDonutsPath);
            string[] expreDonuts = System.IO.File.ReadAllLines(expreDonutsPath);
            //ask the user if they want it in random sets (do you want everyone to have the same random donuts?)
            Console.WriteLine("Are you serving multiple people with these donuts? If so, do you want everyone to get the same random set of donuts?");
            String in1 = Console.ReadLine();
            in1 = in1.ToLower();
            if (in1.Contains("yes"))
            {
                multiSet = true;
                Inquiry1:
                Console.WriteLine("How many donuts do you want each person to recieve?");
                string tmp = Console.ReadLine();
                if (Int32.TryParse(tmp, out donuts))
                {
                    Inquiry2:
                    Console.WriteLine("OK. You want each person to get " + donuts + " donuts. How many people will there be for this rad party?!?");
                    tmp = Console.ReadLine();
                    people = 0;
                    if (Int32.TryParse(tmp, out people))
                    {
                        donuts = donuts * people;
                        Console.WriteLine("This means that you want to order " + donuts + " donuts? Fine by me.");
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
                tmp2 = Console.ReadLine();
                if (!Int32.TryParse(tmp2, out donuts))
                {
                    Console.WriteLine("Sorry. I didn't quite get that. Try again please.");
                    goto Inquiry3;
                }
            }
            Console.WriteLine("Allrighty! I will now generate a list of " + donuts + " random Krispy Kreme donuts!");
            Console.WriteLine("GENERATING!");
            Random rnd = new Random();
            int realisticCount = 0;
            if (donuts > 47)
            {
                realisticCount = 47;
            }
            else
            {
                realisticCount = donuts;
            }
            StreamWriter sw = File.AppendText(outputDonutsPath);
            for (int i = 0; i <= donuts; i++)
            {
                        
                sw.WriteLine(regDonuts[rnd.Next(realisticCount)]);
                Console.WriteLine(regDonuts[rnd.Next(realisticCount)]);
            }
            Console.WriteLine("Donut generation complete. Would you like to see the list of donuts?");
            Console.ReadLine();
            Console.ReadLine();
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
