
namespace Event_exercises
{
    public class StockAlert
    {
        private readonly decimal threshold;

        public StockAlert(decimal threshold)
        {
            this.threshold = threshold;
        }
        public void Subscribe(Stock stock)
        {
            stock.PriceChanged += Stock_PriceChanged;
        }
        public void Unsubscribe(Stock stock)
        {
            stock.PriceChanged -= Stock_PriceChanged;
        }
        private void Stock_PriceChanged(Stock stock, decimal oldPrice, decimal newPrice)
        {
            if (newPrice > threshold)
            {
                Console.WriteLine($"Alert: {stock.Symbol} price has exceeded the threshold! Current price: {newPrice}");
            }
        }
    }
}
