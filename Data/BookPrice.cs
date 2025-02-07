namespace EntityFrameworkCoreProject1.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        
        //foreign key from Books table
        public Book Book { get; set; }
        public int BookId { get; set; }


        public int Amount { get; set; }
        
        //foreign key from Currencies table
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
    }
}
