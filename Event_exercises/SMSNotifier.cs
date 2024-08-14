
namespace Event_exercises
{
    public class SMSNotifier
    {
        public void Subscribe(Store store)
        {
            store.orderPlaced += Store_orderPlaced;
        }
        public void Unsubscribe(Store store)
        {
            store.orderPlaced -= Store_orderPlaced;
        }

        private void Store_orderPlaced(int id, string customerName)
        {
            Console.WriteLine($" subscribe of SMS is id : {id + 1} and name is :{customerName}");
        }
    }
}
