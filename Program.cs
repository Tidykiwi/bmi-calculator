using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exit method allows user to exit the program at any point where they are able to add input
            void EXIT()
            {
                Console.Clear(); // Clears the console
                Console.WriteLine("\nGoodbye until next time!\n"); // Goodbye message
                System.Threading.Thread.Sleep(2250); // 2.25 second pause
                Environment.Exit(0); // Exit the program
            }

            // Welcome page
            Console.WriteLine("\nWelcome to City Gym\n");
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();

            // While (true); use this to make an outer layer that gives you a way to come back to the main menu using break
            while (true)
            {

                // This body of text is the MAIN menu
                Console.Clear(); // Clears the console of any text so the menu always appears simple and tidy
                Console.WriteLine("\nMAIN MENU\n");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What would you like to do today???\n");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nTo CALCULATE BMI enter 'bmi' \n");
                Console.WriteLine("\nTo view MEMBERSHIP RATES enter 'rates'\n");
                Console.WriteLine("\nTo return to the MAIN MENU at any stage enter 'menu'\n");
                Console.WriteLine("\nTo EXIT at any stage enter 'exit'\n");


                while (true)
                {
                    string input01 = Console.ReadLine();
                    input01 = input01.ToUpper(); // Convert user input to uppercase - helps with user input errors
                    // List of possible answers. 
                    bool input02 = (input01 == "BMI" || input01 == "RATES" || input01 == "MENU" || input01 == "EXIT");
                    // If any from list is entered bool will be true. If none are entered user will be prompted tp try again.
                    if (input02)
                    {
                        if (input01 == "BMI") // BMI calculation page
                        {
                            double height, weight;
                            Console.Clear();
                            Console.WriteLine("\nLet's calculate your BMI");
                            System.Threading.Thread.Sleep(1000);
                            while (true)
                            {
                                Console.WriteLine("\nPlease enter your height in METERS\n");
                                string userHeight = Console.ReadLine();
                                if ((userHeight = userHeight.ToUpper()) == "MENU") // Convert user input to uppercase - helps with user input errors
                                {
                                    // Get out of the inner loops to a point where it is possible to break to return to the menu
                                    goto menu;
                                }
                                if ((userHeight = userHeight.ToUpper()) == "EXIT") // Convert user input to uppercase - helps with user input errors
                                {
                                    EXIT();
                                }
                                // Converts user input to a double for calculations and checks if number is positive
                                if (Double.TryParse(userHeight, out height) && height > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nYour input was invalid. Please try again...");
                                }
                            }
                            while (true)
                            {
                                Console.WriteLine("\nPlease enter your weight in KILOGRAMS\n");
                                string userWeight = Console.ReadLine();
                                if ((userWeight = userWeight.ToUpper()) == "MENU")
                                {
                                    // Get out of the inner loops to a point where it is possible to break to return to the menu
                                    goto menu;
                                }
                                if ((userWeight = userWeight.ToUpper()) == "EXIT") // Convert user input to uppercase - helps with user input errors
                                {
                                    EXIT();
                                }
                                // Converts user input to a double for calculations and checks if number is positive
                                else if (Double.TryParse(userWeight, out weight) && weight > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nYour input was invalid. Please try again...");
                                }
                            }
                            // Perform the BMI calculation
                            double result = (weight / (height * height));
                            double rounded = Math.Round((Double)result, 2); // Rounds result to 2 decimal places
                            Console.WriteLine("\nYour BMI is: " + rounded);
                            // Gives feedback to the iser based on the result
                            if (result < 18.5)
                            {
                                Console.WriteLine("\nAccording to this BMI calaculation you are UNDERWEIGHT");
                            }
                            else if (result >= 18.5 && result < 25)
                            {
                                Console.WriteLine("\nAccording to this BMI calculation you are NORMAL");
                            }
                            else if (result >= 25 && result < 30)
                            {
                                Console.WriteLine("\nAccording to this BMI calculation you are OVERWEIGHT");
                            }
                            else if (result >= 30)
                            {
                                Console.WriteLine("\nAccording to this BMI calculation you are OBESE");
                            }
                            while (true)
                            {
                                Console.WriteLine("\nWhat would you like to now?\n \nEnter EXIT to quit or MENU to return to the main menu\n");
                                string whatNow = Console.ReadLine();
                                whatNow = whatNow.ToUpper(); // Convert user input to uppercase - helps with user input errors
                                if (whatNow == "EXIT")
                                {
                                    EXIT();
                                }
                                else if (whatNow == "MENU")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nYour input was invalid... Please try again");
                                }
                            }
                        // Goto menu brings you here
                        // The following step is to break out of the main while(true) loop and return to the menu 
                        menu:
                            break;
                        }
                        else if (input01 == "RATES") // Membership rates page
                        {
                            Console.Clear();
                            Console.WriteLine("\nLet's look at membership rates...\n");
                            System.Threading.Thread.Sleep(1000);


                            while (true)
                            {
                                Console.WriteLine("We offer 3 types of membership\n");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("BASIC membership\nREGULAR membership\nPREMIUM membership\n");
                                System.Threading.Thread.Sleep(1000);

                                Console.WriteLine("What type of membership would you like?\n");
                                Console.WriteLine("\nEnter your choice or enter MENU or EXIT\n");
                                string choice = Console.ReadLine();
                                choice = choice.ToUpper(); // Convert user input to uppercase - helps with user input errors
                                // List of possible answers
                                bool ratesChoice = (choice == "BASIC" || choice == "REGULAR" || choice == "PREMIUM" || choice == "MENU" || choice == "EXIT");
                                // If any is entered bool will be true.If none are entered user will be prompted tp try again.
                                if (ratesChoice)
                                {
                                    // Different output based on users input
                                    if (choice == "BASIC")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nBASIC membership is $10 per week / $40 per month\n");
                                        System.Threading.Thread.Sleep(1500);
                                        continue;
                                    }
                                    else if (choice == "REGULAR")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nREGULAR membership is $15 per week / $60 per month\n");
                                        System.Threading.Thread.Sleep(1500);
                                        continue;
                                    }
                                    else if (choice == "PREMIUM")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nPREMIUM membership is $20 per week / $80 per month\n");
                                        System.Threading.Thread.Sleep(1500);
                                        continue;
                                    }
                                    else if (choice == "MENU")
                                    {
                                        break;
                                    }
                                    else if (choice == "EXIT")
                                    {
                                        EXIT();
                                    }

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nYour input was invalid... Please try again\n");
                                }

                            }
                            break;
                        }
                        else if (input01 == "MENU")
                        {
                            break;
                        }
                        else if (input01 == "EXIT")
                        {
                            EXIT();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYour input was invalid... please try again");
                    }
                }
            }
        }
    }
}
