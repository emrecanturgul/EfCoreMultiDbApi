namespace SqlWebApi.Models
{
    public class Company : IEntity
    {
        public Guid CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string?  CountryName { get; set; }    
        //One To Many Relationship (One Company can develop more than one game) 
        public ICollection<Game> Games { get; set; } 
    }
}
