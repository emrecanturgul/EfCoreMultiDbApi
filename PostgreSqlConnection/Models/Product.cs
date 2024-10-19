using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSqlWebAPI.Models
{
    [Table("product")]
    public class Product
    {
        [Key, Required]
        public int Id { get; set; }
    }
}
