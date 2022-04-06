using JsonTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Product shirt = new Product { Id = 1, Name = "Koton", Price = 24.90 };
            Product pants = new Product { Id = 2, Name = "Zara", Price = 30 };
            Product shoe = new Product { Id = 3, Name = "Nike", Price = 27.90 };
            Product bag = new Product { Id = 4, Name = "Chanel", Price = 25 };

            OrderItem item1 = new OrderItem { Id = 1, Product = shirt, Count = 2};
            item1.TotalPrice = shirt.Price * item1.Count;
            OrderItem item2 = new OrderItem { Id = 2, Product = pants, Count = 1, TotalPrice = pants.Price * 1 };
            item2.TotalPrice = pants.Price * item2.Count;
            OrderItem item3 = new OrderItem { Id = 3, Product = shoe, Count = 2, TotalPrice = shoe.Price * 2 };
            item3.TotalPrice = shoe.Price * item3.Count;
            OrderItem item4 = new OrderItem { Id = 4, Product = bag, Count = 3, TotalPrice = bag.Price * 3 };
            item4.TotalPrice = bag.Price * item4.Count;

            List<OrderItem> orderItems1 = new List<OrderItem>();
            orderItems1.Add(item1);
            orderItems1.Add(item2);

            List<OrderItem> orderItems2 = new List<OrderItem>();
            orderItems2.Add(item3);
            orderItems2.Add(item4);

            Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            Order order2 = new Order { Id = 2, OrderItems = orderItems2 };

            #region Serialize
            var jsonObj = JsonConvert.SerializeObject(order1);
            Console.WriteLine(jsonObj);

            string filePath = @"C:\Users\Zulfiyya Huseynova\Desktop\New folder\JsonTask\JsonTask\Files\zulfiyya.json";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(jsonObj);
            }
            #endregion

            #region Deserialize
            //string result;
            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    result = sr.ReadToEnd();
            //}
            //Order order = JsonConvert.DeserializeObject<Order>(result);
            //foreach (var item in order.OrderItems)
            //{
            //    Console.WriteLine(item.Product.Name);
            //}
            #endregion
        }
    }
}
