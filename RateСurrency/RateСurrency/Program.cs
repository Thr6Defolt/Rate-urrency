namespace RateСurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RateCurrency<string> exchangeRateBoard = new RateCurrency<string>();

            exchangeRateBoard.ChangeRate("27.5$");
            exchangeRateBoard.ChangeRate("30.4$");
            exchangeRateBoard.ChangeRate("29.7$");

            exchangeRateBoard.PrintHistory();
        }
    }
}