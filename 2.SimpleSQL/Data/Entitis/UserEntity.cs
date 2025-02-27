using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SimpleSQL.Data.Entitis{
    [Table("tbl_Users")]
    public class UserEntity{
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string FName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LName { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Email { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string? Phone { get; set; } = string.Empty;

        [Required]
        public DateOnly? Birthday { get; set;}
    }
}
