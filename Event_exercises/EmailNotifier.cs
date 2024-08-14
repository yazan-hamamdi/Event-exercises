
namespace Event_exercises
{
    public class EmailNotifier
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
            Console.WriteLine($" subscribe of Email is id : {id} and name is :{customerName}");
        }
    }
}
