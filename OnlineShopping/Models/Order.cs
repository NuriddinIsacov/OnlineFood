using System.Collections.Generic;

namespace OnlineFood.Models
{
    public class Order
    {
        public int Id { get; set; }
        public IList<OrderDetails> Orders { get; set; }

    }
}
