using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.API.Data
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        public string UserId { get; set; }

        public int RoleId { get; set; } 
    }
}
