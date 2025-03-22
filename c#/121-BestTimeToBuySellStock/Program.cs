namespace _121_BestTimeToBuySellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = [7, 1, 5, 3, 6, 4];
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices == null ||  prices.Length < 2)
            {
                return 0;
            }
            int maxProfit = 0;
            int leftBuy = 0;
            int rightSell = 1;
            while (rightSell < prices.Length)
            {
                int currentPrice = prices[rightSell];
                int buyPrice = prices[leftBuy];
                if (buyPrice < currentPrice)
                {
                    int currentProfit = currentPrice - buyPrice;
                    maxProfit = Math.Max(maxProfit, currentProfit);
                }
                else
                {
                    leftBuy = rightSell;
                }

                rightSell++;
            }
            return maxProfit;
        }
    }
}
