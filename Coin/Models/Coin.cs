namespace Coin 
{
    public class CoinCal  
    {
        private static int _quarters;
        private static int _dimes; 
        public static int GetQuarters() 
        {
            return _quarters; 
        }
        public static int GetDimes()
        {
            return _dimes;
        }
        public static void SetQuarter(int newQuarter)
        {
            _quarters = newQuarter;
        }

        public static void ClearAll()
        {
            CoinCal.SetQuarter(0); 
            _dimes = 0;         
        }
        public static void  CalculateCoins(int cents)
        {
            if( cents >= 25)
            {
                _quarters++;
                CalculateCoins(cents-25);
            }
            else if ( cents >= 10)
            {
                _dimes++;
                CalculateCoins(cents-10);
            }
        }
    }
}