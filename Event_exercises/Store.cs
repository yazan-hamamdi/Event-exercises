
namespace Event_exercises
{
    public delegate void OrderPlacedHandler(int id, string customerName);
    public class Store
    {
        public int Id { set; get; }
        public string CustomerName { set; get; }
        public Store(int id , string customerName)
        {
            Id = id;
            CustomerName = customerName;

        }
        public event OrderPlacedHandler orderPlaced;
        public void OrderPlaced(int id, string customerName)
        {
            OnOrderPlaced(id, customerName);
        }
        protected virtual void OnOrderPlaced(int id, string customerName)
        {
            orderPlaced?.Invoke(id, customerName);
        }
    }
}
