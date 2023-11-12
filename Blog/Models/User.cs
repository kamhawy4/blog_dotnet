using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Models
{
    [Table("Users", Schema = "news")]
    public class User
    {
        [Key]
        [Display(Name = "ID")]
        public int? UserId { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Name")]
        [Required]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Password")]
        [Required]
        public int? Password { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+[A-Za-z0-9.-]+\.[A-Za-z] {2,4}")]
        public String? Email { get; set; }


        [Required]
        [Display(Name = "Created_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
        public DateTime Created_at { get; set; }
    }
}

