using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Andrey_and_Billiard
{
    class Customer
    { 
        public Dictionary<string, int> shopList { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Customer> clientList = new Dictionary<string, Customer>();

            Dictionary<string, decimal> varietyOfProducts = new Dictionary<string, decimal>();
            int numberOfProductsInTheStore = int.Parse(Console.ReadLine());
            decimal sumBillsOfAllStudents = 0;

            for (int i = 1; i <= numberOfProductsInTheStore; i++)
            {
                List<string> productAndPrice = Console.ReadLine().Split('-').ToList();
                var typeOfProduct = productAndPrice[0];
                var priceOfProduct = decimal.Parse(productAndPrice[1]);

                varietyOfProducts[typeOfProduct] = priceOfProduct;
            }

            string input;
            while ((input = Console.ReadLine()) != "end of clients")
            {
                List<string> clientsOrders = input.Split('-', ',').ToList();
                
                var name = clientsOrders[0];
                var product = clientsOrders[1];
                var quantity = int.Parse(clientsOrders[2]);

                if (!varietyOfProducts.ContainsKey(product))
                {
                    continue;
                }

                if (!clientList.ContainsKey(name))
                {
                    clientList[name] = new Customer
                    {
                        shopList = new Dictionary<string, int>(),
                        Bill = varietyOfProducts[product] * quantity
                    };

                    if (!clientList[name].shopList.ContainsKey(product))
                    {
                        clientList[name].shopList[product] = quantity;
                    }
                }
                else
                {
                    if (!clientList[name].shopList.ContainsKey(product))
                    {
                        clientList[name].shopList[product] = quantity;
                        clientList[name].Bill += quantity * varietyOfProducts[product];
                    }
                    else
                    {
                        clientList[name].shopList[product] += quantity;
                        clientList[name].Bill += quantity * varietyOfProducts[product];
                    }
                }
            }
            
            foreach (var customer in clientList.OrderBy(p => p.Key))
            {
                Console.WriteLine(customer.Key);

                foreach (var item in customer.Value.shopList)
                {

                    Console.WriteLine($"-- {item.Key} - {item.Value}");

                }
                Console.WriteLine($"Bill: {customer.Value.Bill:F2}");
                sumBillsOfAllStudents += customer.Value.Bill;
            }
            Console.WriteLine($"Total bill: {sumBillsOfAllStudents:F2}");
        }
    }
}

