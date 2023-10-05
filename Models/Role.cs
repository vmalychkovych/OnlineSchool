using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace OnlineSchool.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Roles { get; set; }
    }
}
