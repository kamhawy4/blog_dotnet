using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Models
{
    [Table("Categories", Schema = "news")]
    public class Categories
    {
        [Key]
        [Display(Name = "ID")]
        public int? CategoriesId { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Title")]
        [Required]
        public string? Title { get; set; }

        [Required]
        [Display(Name = "Created_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
        public DateTime Created_at { get; set; }

    }
}

