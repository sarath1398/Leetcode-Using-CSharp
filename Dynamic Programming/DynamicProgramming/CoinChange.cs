namespace DynamicProgramming;

public class CoinChange : Program
{
    public int CoinChangeFn(int[] coins, int amount) {
        int[] cacheArray = new int[amount+1];
        // Pre-Populate the cache with coin values - Doing so since 1 is the global minima
        for(int i = 0; i < amount+1 ; i++)
        {
            // Arigato Buffer Overflow testcase!
            cacheArray[i] = int.MaxValue - 1;
        }
        foreach(int c in coins)
        {
            // Out of bounds check
            if(c < amount)
            {
                cacheArray[c] = 1;
            }
        }
        cacheArray[0] = 0;
        for(int i = 1 ; i < amount + 1; i++)
        {
            if(cacheArray[i] != 1)
            {
                foreach(int c in coins)
                {
                    if(i - c >= 0) 
                    {
                        cacheArray[i] = Math.Min(cacheArray[i], 1 + cacheArray[i-c]);
                    }
                }
            }
        }
        return cacheArray[amount] == int.MaxValue - 1 ? -1 : cacheArray[amount];
    }
}