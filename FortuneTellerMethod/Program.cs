using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! What is your first name?");
            string firstName = (Console.ReadLine());

            Console.WriteLine("What is your last name?");
            string lastName = (Console.ReadLine());

            Greeting(firstName, lastName);

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int numberOfSibling = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, type \"Help\"");
            string favoriteColor = Console.ReadLine().ToUpper();


            Console.WriteLine(firstName + " " + lastName + " will retire in " + YearsTilRetirement(age) + " years with " + RetirementFunds(birthMonth) + " in the bank, a vacation home in " + VacationHome(numberOfSibling) + " and a " + Transportation(favoriteColor));
            JudgeFortune();
        }


        static void Greeting(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Greetings, " + fullName + ". I will tell you your fortune!");
        }


        static int YearsTilRetirement(int age)
        {
            int retire;
            if (age % 2 == 0)
            {
                retire = 5;
                return retire;
            }
            else
            {
                retire = 15;
                return retire;
            }
        }


        static string VacationHome(int numberOfSiblings)
        {
            string place;
            if (numberOfSiblings == 0)
            {
                place = "Hawaii";
                return place;
            }
            else if (numberOfSiblings == 1)
            {
                place = "Paris";
                return place;
            }
            else if (numberOfSiblings == 2) 
            {
                place = "Los Angeles";
                return place;
            }
            else if (numberOfSiblings == 3)
            {
                place = "New York";
                return place;
            }
            else if (numberOfSiblings > 3)
            {
                place = "Miami";
                return place;
            }
            else
            {
                place = "The hood of Detroit";
                return place;
            }
        }


        static double RetirementFunds(int birthMonth)
        {
            double moneyInBank;
            if (birthMonth >= 9)
            {
                moneyInBank = 10000;
                return moneyInBank;
            }
            else if (birthMonth >= 5)
            {
                moneyInBank = 5000;
                return moneyInBank;
            }
            else if (birthMonth >= 1)
            {
                moneyInBank = 1000000;
                return moneyInBank;
            }
            else
            {
                moneyInBank = 0;
                return moneyInBank;
            }
        }


        static string Transportation(string favoriteColor)
        {
            string vehicle;
            if (favoriteColor == "Help".ToUpper())
            {
                Console.WriteLine("ROYGBIV are the colors:");
                Console.WriteLine("Red");
                Console.WriteLine("Orange");
                Console.WriteLine("Yellow");
                Console.WriteLine("Green");
                Console.WriteLine("Blue");
                Console.WriteLine("Indigo");
                Console.WriteLine("Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                favoriteColor = Console.ReadLine().ToUpper();

                if (favoriteColor == "Red".ToUpper())
                {
                    vehicle = "Ferrari";
                    return vehicle;
                }
                else if (favoriteColor == "Orange".ToUpper())
                {
                    vehicle = "lamborghini";
                    return vehicle;
                }
                else if (favoriteColor == "Yellow".ToUpper())
                {
                    vehicle = "Mclaren";
                    return vehicle;
                }
                else if (favoriteColor == "Green".ToUpper())
                {
                    vehicle = "Private Jet";
                    return vehicle;
                }
                else if (favoriteColor == "Blue".ToUpper())
                {
                    vehicle = "Hellcat Charger";
                    return vehicle;
                }
                else if (favoriteColor == "Indigo".ToUpper())
                {
                    vehicle = "Paddle boat";
                    return vehicle;
                }
                else if (favoriteColor == "Violet".ToUpper())
                {
                    vehicle = "Hellicopter";
                    return vehicle;
                }
                else
                {
                    vehicle = "Squeaky shopping cart";
                    return vehicle;
                }
            }

            else if (favoriteColor == "Red".ToUpper())
            {
                vehicle = "Ferrari";
                return vehicle;
            }
            else if (favoriteColor == "Orange".ToUpper())
            {
                vehicle = "Lamborghini";
                return vehicle;
            }
            else if (favoriteColor == "Yellow".ToUpper())
            {
                vehicle = "Mclaren";
                return vehicle;
            }
            else if (favoriteColor == "Green".ToUpper())
            {
                vehicle = "Private Jet";
                return vehicle;
            }
            else if (favoriteColor == "Blue".ToUpper())
            {
                vehicle = "Hellcat Charger";
                return vehicle;
            }
            else if (favoriteColor == "Indigo".ToUpper())
            {
                vehicle = "Paddle boat";
                return vehicle;
            }
            else if (favoriteColor == "Violet".ToUpper())
            {
                vehicle = "Hellicopter";
                return vehicle;
            }
            else
            {
                vehicle = "Squeaky shopping cart";
                return vehicle;
            }
        }


        static void JudgeFortune()
        {
            Console.WriteLine("You have a unique fortune.");
        }
    }
}
