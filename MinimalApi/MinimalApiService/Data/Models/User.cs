using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApiService.Data.Models
{
    [Table("users")]
    [DisplayName("Пользователи")]
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
