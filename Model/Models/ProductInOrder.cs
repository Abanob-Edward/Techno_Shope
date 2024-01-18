using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class ProductInOrder
    {



        public int ID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("item")]
        public int itemID { get; set; }
        public Item item { get; set; }
        /*
        public string? Color { get; set; }
        public float? Inch { get; set; }
        public int? Storge { get; set; }*/
        [ForeignKey("order")]
        public int OrderNumber { get; set; }
        public Order order { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }
        public Product  Product { get; set; }
     




    }
}
