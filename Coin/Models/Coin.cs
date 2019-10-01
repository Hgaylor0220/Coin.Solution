namespace Coin // step one, create a namespace for your class
{
public class CoinCal // step two, create a class. 
{
    private static int _quarters; // step three add your properties of your class. These will be the properties that get applied to your method
    public static int GetQuarters() // step four, add your method that you will be running on your properties
    {
        return _quarters; // step five return the updated property after the method is called
    } 

}
}