using System;

namespace MyApp
{
    internal class Program
    {
        static void DoSomeCalculations()
        {
            int apples = 6, oranges = 4, totalFruits = 0, baskets = 3;
            double fruitCost = 0.0;
            const double pricePerBasket = 10.0;

            // Basic arithmetic operations
            totalFruits = apples + oranges;
            apples = (apples * 2) - baskets;  
            oranges = (oranges + 2) % 5; 

            Console.WriteLine("apples = " + apples);
            Console.WriteLine("oranges = " + oranges);
            Console.WriteLine("totalFruits = " + totalFruits);

            // Calculate fruit cost using total fruits and baskets
            fruitCost = totalFruits * baskets * pricePerBasket;

            // Adjust baskets using modulo and some arithmetic
            baskets = (apples + oranges) % 4;

            Console.WriteLine("baskets = " + baskets);
            Console.WriteLine("fruit cost = " + fruitCost);

        }

        static void AverageCostofWidgetsAbove()
        {
            double[] widgetsSoldPrice = { 50.29, 495.2, 599.95, 295.42, 9985.00 };
            int widgetsSoldCount = 5;
            const double priceCutoff = 450.55;
            double averagePrice;
            double sumPrices = 0.0;
            int numberOfWidgetsForCutOff = 0;
            int index;

            // loop through all of the widgetsSoldPrice array
            for (index = 0; index < widgetsSoldCount; index++)
            {
                // if the particular widget sold price is more than the
                // price cut off
                if (widgetsSoldPrice[index] > priceCutoff)
                {
                    // add the price to the sum of prices
                    sumPrices += widgetsSoldPrice[index];
                    // keep track of the number of widgets that fit the
                    // cut off criteria
                    numberOfWidgetsForCutOff++;
                }
            }
            averagePrice = sumPrices / numberOfWidgetsForCutOff;


            Console.WriteLine("Average price of widgets priced > " + priceCutoff
                                + "  is: " + averagePrice);

        }
        static void Main(string[] args)
        {
            // Problem 1
            DoSomeCalculations();

            // Problem 2
            AverageCostofWidgetsAbove();


        }
    }
}