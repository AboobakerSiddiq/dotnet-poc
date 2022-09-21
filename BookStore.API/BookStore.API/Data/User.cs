using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.API.Data
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedAt { get; set; } 

        public string CreatedBy { get; set; }
    }
}
