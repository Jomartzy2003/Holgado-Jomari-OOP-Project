using System;

namespace RewardPoints_OOP
{
    public class JomPointsSystem
    {
        private int jompoints;
        private Menu menu;
        private RewardProcessor rewardProcessor;

        public JomPointsSystem()
        {
            jompoints = 25;
            menu = new Menu();
            rewardProcessor = new RewardProcessor();
        }

        public void StartSystem()
        {
            Console.WriteLine("Welcome to Kuya Joms' Finest Restaurant Loyalty Points System");
            Console.WriteLine("Your balance Jom Points is: " + jompoints);
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("Press 1 to Exchange your Jom Points into BigBoy Prizes");
            Console.WriteLine("Press 2 to Exchange your Jom Points into Advantage Card / Ticket");
            Console.WriteLine("Press 3 to Claim more Jom Points");
            Console.WriteLine("Press 4 to Exit the System");
            Console.WriteLine("______________________________________________________________");

            Console.WriteLine("Select what you want?");
            int selectedOption = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your choice is " + selectedOption);

            while (true)
            {
                if (selectedOption == 1)
                {
                    rewardProcessor.ExchangeBigBoyPrizes(ref jompoints);
                    break;
                }
                else if (selectedOption == 2)
                {
                    rewardProcessor.ExchangeAdvantageCard(ref jompoints);
                    break;
                }
                else if (selectedOption == 3)
                {
                    rewardProcessor.ClaimMorePoints(ref jompoints);
                    break;
                }
                else if (selectedOption == 4)
                {
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("Thanks for visiting us, Stay Loyal!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option selected. Please try again.");
                    Console.WriteLine("Select what you want?");
                    selectedOption = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
