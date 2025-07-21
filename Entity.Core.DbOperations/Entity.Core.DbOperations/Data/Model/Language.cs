namespace Entity.Core.DbOperations.Data.Model
{
    public class Language
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? Description { get; set; }


        public ICollection<Book>? Books { get; set; }
    }
}
