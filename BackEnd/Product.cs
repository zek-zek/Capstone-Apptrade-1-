using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Apptrade.BackEnd
{
    public class Product
    {
        public DateTime dataToday { get; set; }
        public string employeeName { get; set; }
        public int productId { get; set; }
        public int UoM { get; set; }
        public string dateOrdered {get; set;}
        public string supplier { get; set; }
        public int barcode { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public string dateDelivered { get; set; }
        public string receivedBy { get; set; }
        public double price { get; set; }

    }
}
