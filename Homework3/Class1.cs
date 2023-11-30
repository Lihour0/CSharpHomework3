namespace Homework3
{
    internal class Class1
    {
        double price;
        int quantity;
        public void input()
        {
            Console.WriteLine("Enter the price of each and quantity: ");
            price = double.Parse(Console.ReadLine());
            quantity = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Price is: {0}", quantity * price);
        }
    }
}
