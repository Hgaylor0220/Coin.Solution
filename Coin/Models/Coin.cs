namespace Coin 
{
    public class CoinCal  
    {
        private static int _quarters; 
        public static int GetQuarters() 
        {
            return _quarters; 
        } 
        public static void SetQuarter(int newQuarter)
        {
            _quarters = newQuarter;
        }

        public static void ClearAll()
        {
            CoinCal.SetQuarter(0);          
        }
        public static void  CalculateCoins(int cents)
        {
            if( cents >= 25)
            {
                _quarters++;
                CalculateCoins(cents-25);
            }
        }
    }
}