using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    [Table("Genres")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}