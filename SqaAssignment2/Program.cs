using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaAssignment2
{
    class Program
    {
        // Create a new dictionary of options
        static Dictionary<int, string> optionsDict = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            // Adding key/value pairs in optionsDict
            optionsDict.Add(1, "Enter triangle dimensions");
            optionsDict.Add(2, "Exit");

            Program p = new Program();
            p.go();

        }

        public void go()
        {

            string firstSide = string.Empty;
            string secondSide = string.Empty;
            string thirdSide = string.Empty;

            int firstSides = 0;
            int secondSides = 0;
            int thirdSides = 0;

            Console.WriteLine("***************************************");
            Console.WriteLine("* Welcome to assignment 2 - Triangles *");

            bool keepMenu = true;
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("*                Menu                 *");

                string opt = string.Empty;
                int opts = 0;
                do
                {
                    if (opt != string.Empty)
                    {
                        Console.WriteLine("Option no valid. Please enter one option from the menu");
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                    }
                    Console.WriteLine("***************************************");
                    foreach (KeyValuePair<int, string> option in optionsDict)
                    {
                        Console.WriteLine("{0} - {1}", option.Key, option.Value);
                    }
                    Console.WriteLine("***************************************");
                    
                    Console.WriteLine("Please, choose an option from the menu above");
                    Console.WriteLine("");
                    Console.Write("Option: ");
                    opt = Console.ReadLine();
                } while (!int.TryParse(opt, out opts) || (opts <= 0 || opts > 2));

                Console.WriteLine("");
                switch (opts)
                {
                    case 1:

                        firstSide = string.Empty;
                        firstSides = 0;
                        do
                        {
                            if (firstSide != string.Empty)
                            {
                                Console.WriteLine("Input error: Please enter a number greater than zero");
                            }
                            Console.Write("Please enter side A: ");
                            firstSide = Console.ReadLine();
                        } while (!int.TryParse(firstSide, out firstSides) || (firstSides <= 0));

                        secondSide = string.Empty;
                        secondSides = 0;
                        do
                        {
                            if (secondSide != string.Empty)
                            {
                                Console.WriteLine("Input error: Please enter a number greater than zero");
                            }
                            Console.Write("Please enter side B: ");
                            secondSide = Console.ReadLine();
                        } while (!int.TryParse(secondSide, out secondSides) || (secondSides <= 0));

                        thirdSide = string.Empty;
                        thirdSides = 0;
                        do
                        {
                            if (thirdSide != string.Empty)
                            {
                                Console.WriteLine("Input error: Please enter a number greater than zero");
                            }
                            Console.Write("Please enter side C: ");
                            thirdSide = Console.ReadLine();
                        } while (!int.TryParse(thirdSide, out thirdSides) || (thirdSides <= 0));


                        string triangle = TriangleSolver.Analyze(firstSides, secondSides, thirdSides);
                        if (triangle.Equals(""))
                            Console.WriteLine("The numbers entered DO NOT form a triangle");
                        else
                        {
                            Console.WriteLine("The numbers entered DO form a triangle");
                            Console.WriteLine("The triangle is " + triangle);
                        }

                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();

                        break;                    
                    case 2:
                        // Program exits
                        keepMenu = false;
                        break;
                    default:
                        break;
                }

            } while (keepMenu == true);

        }

    }
}
