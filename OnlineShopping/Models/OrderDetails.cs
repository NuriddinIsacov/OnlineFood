namespace OnlineFood.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public Food Food { get; set; }
        public int Count { get; set; }
    }
}
