namespace SqlWebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Email { get; set; }
        //one to many relationship 
        public ICollection<Comment> Comments { get; set; }
    }
}
