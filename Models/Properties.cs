using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CordysWebsite.Models
{
    public class Properties
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public int Tel { get; set; }
        public string Product { get; set; }
        public string Store { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public List<Properties> SalesAmount { get; set; }
    }
}