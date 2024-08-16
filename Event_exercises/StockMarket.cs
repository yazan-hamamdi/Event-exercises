
namespace Event_exercises
{
    public class StockMarket
    {
        private readonly List<Stock> _stocks = new List<Stock>();
        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
        }
    }
}
