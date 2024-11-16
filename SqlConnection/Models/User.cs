namespace SqlWebApi.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        //one to many relationship 
        public ICollection<Comment> Comments { get; set; }
    }
}
