namespace Records.LIB.Model
{
    public class Tool : IBaseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Deposit { get; set; }
        public int RentPrice { get; set; }
    }
}