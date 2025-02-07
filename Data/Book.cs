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

        //creating a foreign key from Language table starts
        public Language Language { get; set; }

        //the below line is optional as by default system itself create Foreign key like {TableName}{PrimaryColumnName} i.e. LanguageId in this case
        public int LanguageId { get; set; }
        //creating a foreign key ends
    }
}
