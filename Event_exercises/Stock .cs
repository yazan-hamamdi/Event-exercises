
namespace Event_exercises
{
    public delegate void PriceChangedHandler(Stock stock, decimal oldPrice, decimal currentPrice);
    public class Stock
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal OldPrice { get; set; }
        public long Volume { get; set; } // number of shares traded during a specific period (usually a day). 
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public Stock()
        {
            
        }
        public Stock(string symbol, string companyName, decimal currentPrice, decimal oldPrice, long volume, decimal dayHigh, decimal dayLow)
        {
            Symbol = symbol;
            CompanyName = companyName;
            CurrentPrice = currentPrice;
            OldPrice = oldPrice;
            Volume = volume;
            DayHigh = dayHigh;
            DayLow = dayLow;
        }
        public event PriceChangedHandler PriceChanged;
        public void ChangePriceBy( decimal percent)
        {
            OldPrice = CurrentPrice;
            decimal newPrice = CurrentPrice * percent;
            CurrentPrice += newPrice;
        }
        protected virtual void OnPriceChanged(decimal oldPrice, decimal newPrice)
        {
            PriceChanged?.Invoke(this, oldPrice, newPrice);
        }
    }
}
