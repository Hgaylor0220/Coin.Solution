namespace Coin 
{
    public class CoinCal  
    {
        private static int _quarters;
        private static int _dimes;
        private static int _nickels;
        public static int GetQuarters() 
        {
            return _quarters; 
        }
        public static int GetDimes()
        {
            return _dimes;
        }
        public static int GetNickels()
        {
            return _nickels;
        }
        public static void SetQuarter(int newQuarter)
        {
            _quarters = newQuarter;
        }

        public static void ClearAll()
        {
            CoinCal.SetQuarter(0); 
            _dimes = 0;
            _nickels =0;         
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
            else if ( cents >= 5)
            {
                _nickels++;
                CalculateCoins(cents-5);
            }
        }
    }
}