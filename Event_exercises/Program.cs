namespace Event_exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store(5 , "Yazan");
            Store store2 = new Store(234, "Talal");

            SMSNotifier smsNotifier = new SMSNotifier();
            EmailNotifier emailNotifier = new EmailNotifier();
            smsNotifier.Subscribe(store1);
            emailNotifier.Subscribe(store2);
            store1.OrderPlaced(4, "Yazan");
            store2.OrderPlaced(4, "Yazan");

        }
    }
}