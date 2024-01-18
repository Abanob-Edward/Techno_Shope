using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Order
    {

        public int Id { get; set; }

        public DateTime  OrderDate         { get; set; }
          public decimal totalprice { get; set; }

         public ICollection<ProductInOrder> ProductInOrders { get; set; }
         public User User { get; set; }
    }
}
