using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.API.Data
{
    [Table("Role")]
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public bool Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }
    }
}
