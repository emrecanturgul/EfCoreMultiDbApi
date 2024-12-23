﻿using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace SqlWebApi.Models
{
    public class Platform : IEntity
    {
        public Guid Id  { get; set; }
        public string? PlatformName  { get; set; }
      //many to many relationship(one platform can have more than one game  , one game can have more than one platform )
        public ICollection<Game> Games  { get; set; }
    }
}
