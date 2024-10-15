using ProductInfoAndSales.Models;
namespace ProductInfoAndSales
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many do you want to buy?: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            ////////////////////////////////Brand,  Model,Price, Cost,Count
            Product product1 = new Product("Apple", "15Pro", 1000m, 500m, 10);
            product1.Sale(quantity);
            product1.GetInfo();
        }
    }
}