using System;
using System.Collections.Generic;

namespace StockBuySell
{
    class Interval
    {
        public int buy, sell;
    }

    public class StockBuySell
    {
        void stockBuySell(int[] price, int n)
        {
            if (n == 1)
                return;

            int count = 0;

            List<Interval> sol = new List<Interval>();

            int i = 0;
            while (i < n - 1)
            {
                while ((i < n - 1) && (price[i + 1] <= price[i]))
                    i++;

                if (i == n - 1)
                    break;

                Interval e = new Interval();
                e.buy = i++;

                while ((i < n) && (price[i] >= price[i - 1]))
                    i++;

                e.sell = i - 1;
                sol.Add(e);

                count++;
            }

            if (count == 0)
                Console.WriteLine("There is no day when buying the stock "
                                + "will make profit");
            else
                for (int j = 0; j < count; j++)
                    Console.WriteLine("Buy on day: " + sol[j].buy
                                    + "     "
                                    + "Sell on day : " + sol[j].sell);

            return;
        }

        public static void Main(String[] args)
        {
            StockBuySell stock = new StockBuySell();

            int[] price = { 100, 180, 260, 310, 40, 535, 695 };
            int n = price.Length;

            stock.stockBuySell(price, n);
        }
    }
}
