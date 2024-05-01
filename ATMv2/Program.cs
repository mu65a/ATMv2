using System;

namespace ATM_software
{

    class Program
    {
        static void Main(string[] args)
        {
            int Balance = 500000;
            int attempts = 3;
            bool Exit = false;

            Console.WriteLine("Ensert your card");

            while (attempts > 0)
            {
                Console.WriteLine("Enter your PIN:");
                int pin = Convert.ToInt32(Console.ReadLine());
                if (pin == 101213) // this pin designed for one user
                {
                    Console.WriteLine("Thank You\n");
                    break; //exit the loopif PIN is correct then jump to switch

                }
                else
                {
                    Console.WriteLine("sorry, incorrect pin for the entered card");
                    attempts--;
                    if (attempts == 0) //if attempts is over .the cared will be locked 
                    {
                        Console.WriteLine("you'r card is locked.");
                    }
                    Console.Beep();// make sound if the  PIN not correct

                }
            }
            if (attempts > 0)
            {
                string service;
                do
                {
                    Console.WriteLine("Choose the service that you want by pressing the number:\n" +
                        "Press 1 to Deopsit cash.\n" +
                        "Press 2 to withdraw cash.\n" +
                        "Press 3 to check your balance.");

                    service = Console.ReadLine();

                    switch (service)
                    {      // here the service that custemer can choose

                        case "1":
                            Console.WriteLine("Deopsit Cash");//ايداع
                            Console.WriteLine("How much would you like to add to your account");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Loading");
                            deposit = Balance + deposit;
                            Console.WriteLine($"You'r current Balance is {deposit}");
                            break;

                        case "2":
                            Console.WriteLine("withdraw cash");  //سحب
                            Console.Write("How much do you want to widthdraw ? ");
                            int money = Convert.ToInt32(Console.ReadLine());
                            if (Balance >= money)
                            {
                                Console.WriteLine($"Now your balance is: {Balance -= money}");
                                Console.WriteLine("Done");
                            }
                            else
                            {
                                Console.WriteLine("Your balance is not sufficient for this operation");
                            }
                            break;

                        case "3":
                            Console.WriteLine("Check your balance");
                            Console.WriteLine($"Your balance is: {Balance}");
                            break;

                        default:
                            Console.WriteLine("sorry.Make sure you chosen number");
                            break;
                    }

                    Console.WriteLine("Do you want contiune? (y=Yes, n=No): ");
                    if (Console.ReadLine().ToUpper() == "N")
                        Exit = true;

                } while (!Exit);
                Console.WriteLine("Thank You.");
                Console.WriteLine("don't forget your card.");
            }
            Console.ReadKey();
        }
    }
}
