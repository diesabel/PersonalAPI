using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAPI.Models
{
    public class PasswordManager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PlatformName { get; set; }
        public string UserName { get; set; }
        public string Value { get; set; }
    }
}
