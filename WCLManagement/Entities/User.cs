using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WCLManagement.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(50)]  
        public string FirstName { get; set; }
       
        [StringLength(50)]
        public string LastName { get; set; }
        
        [StringLength(50)]
        public string Username { get; set; }
        
        [StringLength(50)]
        public string Email { get;set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
