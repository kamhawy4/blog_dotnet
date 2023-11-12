using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Models
{
    [Table("Posts", Schema = "news")]
    public class Posts
    {
        [Key]
        [Display(Name = "ID")]
        public int? PostId { get; set; }


        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Title")]
        [Required]
        public string? Title { get; set; }


        [Column(TypeName = "varchar(max)")]
        [Display(Name = "Content")]
        [MaxLength(1000)]
        [MinLength(1000)]
        public string? Content { get; set; }


        [Display(Name = "Categories")]
        public int CategorieId { get; set; }
        [ForeignKey("CategoriesId")]
        public Categories? Categories { get; set; }


        [Display(Name = "User")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }


        [Required]
        [Display(Name = "Created_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
        public DateTime Created_at { get; set; }

    }
}

