using System.ComponentModel.DataAnnotations;

namespace Postgre_Sql_Connection.Models
{
    public class Product
    {
       
            [Key, Required]
            public int Id { get; set; }
        
    }
}
