using SqlWebApi.Enums;
using System.Reflection.PortableExecutable;

namespace SqlWebApi.Models
{
    public class Comment : IEntity
    {
        public Guid Id { get; set; }
        public string? CommentTitle { get; set; }
        public RatingScale Rating { get; set; }

        public Guid GameId  { get; set; }
        public Guid UserId { get; set; }
        // one to many 
        public Game Game { get; set; }
        //one to many 
        public User User { get; set; }
        

    }
}
