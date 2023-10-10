using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("prd-001", 400, "Apple", "Ноутбук", 20000, true, "Америка");
            Product product1 = new Product("SKU12345", 30, "Android", "Смартфон", 25000, false, "Европа");
            Service service = new Service(2, "380151666138", "Массаж", "Массаж Спины", 250, true, "Приморский");
            Logistics logistics = new Logistics("Поезд", "Киев", "Одесса", "Консоль", 3600, true, "Киев");

            BusinessInfo businessCommerce = new BusinessInfo();

            businessCommerce.AddBusiness(product);
            businessCommerce.AddBusiness(product1);
            businessCommerce.AddBusiness(service);
            businessCommerce.AddBusiness(logistics);

            foreach (var business in businessCommerce.BusinessCommerce)
            {
                Console.WriteLine(business);
            }

            Console.WriteLine("\n----------------------------------------\n");
            Console.WriteLine("\nУдаление первого элемента массива:");
            businessCommerce.DeleteBusiness(0);
            foreach (var business in businessCommerce.BusinessCommerce)
            {
                Console.WriteLine(business);

            }

            Console.WriteLine("\n----------------------------------------\n");
            Console.WriteLine("\nРедактирование массива:");

            service.Rating = 5;
            logistics.DestinationLocation = "Прага";
            businessCommerce.EditBusiness(1, product1);

            foreach (var business in businessCommerce.BusinessCommerce)
            {
                Console.WriteLine(business);
            }

            Console.ReadLine();
        }
    }
}
