namespace CodeFirst.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public System.DateTime Date { get; set; }
        public double Value {get; set;}
        public int Payeed { get; set; }
        public int ClientId { get; set; }
        public int Deleted { get; set;}

        public virtual Client Client { get; set; }
        public virtual OrderDetails OrderDetails { get; set }
    }
}