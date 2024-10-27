using Microsoft.EntityFrameworkCore;
using SqlWebApi.Enums;
using System.Reflection;

namespace SqlWebApi.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string? GameName { get; set; }
        public decimal GamePrice { get; set; }
        public GamePlayMode PlayMode  { get; set; }
        public int CompanyId  { get; set; }
        public DateTime ReleaseDate { get; set; }
        //one to many relationship 
        public Company Company { get; set; }

        //many to many relationship 
        public ICollection<Platform> Platforms { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }
}
