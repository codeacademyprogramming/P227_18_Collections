using System;

namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product("D1001",25,ProductCategory.Drink),
                new Product("D1001",18,ProductCategory.Drink),
                new Product("B1011",5,ProductCategory.Bakery),
                new Product("M1021",15,ProductCategory.Meat),
                new Product("B1022",1.5,ProductCategory.Bakery),
                new Product("B1023",2.5,ProductCategory.Bakery),
                new Product("D1101",25,ProductCategory.Drink),
                new Product("M1111",19.5,ProductCategory.Meat),
            };


            foreach (var val in Enum.GetValues(typeof(ProductCategory)))
            {
                Console.WriteLine((byte)val+" - "+val);
            }

            string option;
            byte optionByte;
            do
            {
                Console.WriteLine("Kateqoriyani secin:");
                option = Console.ReadLine();

            } while (!byte.TryParse(option,out optionByte) || !Enum.IsDefined(typeof(ProductCategory),optionByte));

            ProductCategory category = (ProductCategory)optionByte;



            foreach (var item in products)
            {
                if(item.Category == category)
                    Console.WriteLine($"{item.No} - {item.Price}");
            }
        }
    }
}
