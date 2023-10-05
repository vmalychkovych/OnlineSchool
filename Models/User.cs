using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineSchool.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        public string Login { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public int? RoleId { get; set; }
        [ForeignKey("RoleId"), ValidateNever]
        public User Role { get; set; }
    }
}
