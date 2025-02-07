namespace EntityFrameworkCoreProject1.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //for creating one to many relationship between Language and Books table, use the below code
        public ICollection<Book> Books { get; set; }
    }
}
