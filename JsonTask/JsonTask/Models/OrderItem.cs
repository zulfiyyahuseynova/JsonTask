using System;
using System.Collections.Generic;
using System.Text;

namespace JsonTask.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
    }
}
