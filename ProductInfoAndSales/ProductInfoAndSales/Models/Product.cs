namespace ProductInfoAndSales.Models
{
    public class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public decimal Price;
        public decimal Cost;
        public decimal Income = 0;
        public int Count;


        public Product(string brandname, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandname;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

            if (count < 0)
            {
                Count = 0;
            }

            Id = BrandName.Substring(0, 2) + Model.Substring(0, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brandname: {BrandName}\nModel: {Model}\nId: {Id}\nPrice: {Price}\nCost: {Cost}\nIncome: {Income}\nCount: {Count}");
        }

        public void Sale(int quantity)
        {
            if (quantity <= Count)
            {
                decimal income = (Price - Cost) * quantity;
                Income += income;
                Count -= quantity;
            }
            else
            {
                Console.WriteLine($"Not enough products.");
            }
        }
    }
}
