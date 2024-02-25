/*using System;

namespace БлэкДжек_со_шлюхами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userCount = 0;
            int dealerCount = 0;
            Random rand = new Random();
            string choice;

            while (true)
            {
                dealerCount += rand.Next(2, 11);
                Console.WriteLine("The dealer's open card is equal to:" + dealerCount);
                dealerCount += rand.Next(2, 11);
                userCount += rand.Next(2, 11);
                userCount += rand.Next(2, 11);
                Console.WriteLine("You have points:" + userCount);
                while (true)
                {
                    if (dealerCount < 16)
                    {
                        dealerCount += rand.Next(2, 11);
                        Console.WriteLine("The dealer took the card");

                    }
                    else break;
                }
                Console.WriteLine("Press 1 to take another card, or any other card to open");

                while (true)
                {
                    choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                userCount += rand.Next(2, 11);
                                Console.WriteLine("You have points = " + userCount);
                                break;
                            default:
                                break;

                        }
                    
                    if ((userCount >= 21) || (choice != "1"))  break;
            
                }

                break;

            }
            if ((dealerCount > userCount) && (dealerCount <= 21) || (userCount > 21))
            {
                Console.WriteLine("You lose, sucker! " + "at the dealer's " + dealerCount);
            }
            else { Console.WriteLine("You've won this time." + "at the dealer's " + dealerCount); }



        }
    }
}
*/