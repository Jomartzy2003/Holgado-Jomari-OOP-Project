using System;
using System.Collections.Generic;

namespace RewardPoints_OOP
{
    public class RewardProcessor
    {
        private Dictionary<int, int> rewardsPoints;
        private Dictionary<int, string> rewardsNames;

        public RewardProcessor()
        {
            rewardsPoints = new Dictionary<int, int>()
            {
                { 4, 20 },
                { 5, 25 },
                { 6, 30 }
            };

            rewardsNames = new Dictionary<int, string>()
            {
                { 4, "16 oz of Milk Shake" },
                { 5, "Plant-Based Burger Steak" },
                { 6, "Beef-Mushroom Pizza" }
            };
        }

        public void ExchangeBigBoyPrizes(ref int jompoints)
        {
            Menu menu = new Menu();
            menu.FoodMenu();

            Console.WriteLine("Press :");
            int exchangeRewards = Convert.ToInt32(Console.ReadLine());

            if (rewardsPoints.ContainsKey(exchangeRewards))
            {
                int rewardPoints = rewardsPoints[exchangeRewards];
                string rewardName = rewardsNames[exchangeRewards];

                if (jompoints >= rewardPoints)
                {
                    Console.WriteLine("You've successfully exchanged your Jom Points for " + rewardName);
                    jompoints -= rewardPoints;
                    Console.WriteLine("Your new balance Jom Points is " + jompoints);
                }
                else
                {
                    Console.WriteLine("Not enough Jom Points. Earn more to redeem this reward.");
                }
            }
            else
            {
                Console.WriteLine("Invalid reward option selected");
            }
        }

        public void ExchangeAdvantageCard(ref int jompoints)
        {
            Menu menu = new Menu();
            menu.CardMenu();

            Console.WriteLine("Press :");
            int exchangeRewards = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, int> rewardsPoints = new Dictionary<int, int>()
            {
                { 7, 30 },
                { 8, 30 },
                { 9, 15 }
            };

            Dictionary<int, string> rewardsNames = new Dictionary<int, string>()
            {
                { 7, "300-Peso Gift Voucher" },
                { 8, "Buy 9 Get 1 Free Card" },
                { 9, "1 Million Mega Raffle Draw Ticket" }
            };

            if (rewardsPoints.ContainsKey(exchangeRewards))
            {
                int rewardPoints = rewardsPoints[exchangeRewards];
                string rewardName = rewardsNames[exchangeRewards];

                if (jompoints >= rewardPoints)
                {
                    Console.WriteLine("_______________________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine("Exchange complete, please proceed to the cashier");
                    jompoints -= rewardPoints;
                    Console.WriteLine("Your new balance Jom Points is " + jompoints);
                }
                else
                {
                    Console.WriteLine("Exchange failed, not enough Jom Points");
                }
            }
            else
            {
                Console.WriteLine("Invalid reward option selected");
            }
        }

        public void ClaimMorePoints(ref int jompoints)
        {
            int validCode = 1873293;
            int bonusPoints = 30;
            Console.WriteLine("Enter the code for additional Jom Points:");
            int enterCode = Convert.ToInt32(Console.ReadLine());
            if (enterCode == validCode)
            {
                Console.WriteLine("Your submitted code is valid");
                jompoints += bonusPoints;
                Console.WriteLine("Your new balance is " + jompoints);
            }
            else
            {
                Console.WriteLine("Invalid code submitted, please try again");
            }
        }
    }
}

