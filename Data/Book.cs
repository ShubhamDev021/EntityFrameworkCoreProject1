namespace EntityFrameworkCoreProject1.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Column1 { get; set; }
        public int Column2 { get; set; }
        public int Column3 { get; set; }
        public int Column4 { get; set; }
    }
}
