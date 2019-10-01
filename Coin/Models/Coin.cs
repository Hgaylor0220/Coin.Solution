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
    }
}