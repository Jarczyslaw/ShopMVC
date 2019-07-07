using System;
using System.ComponentModel.DataAnnotations;

namespace ShopMVC.DataAccess.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Insert course title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Insert course author")]
        [StringLength(50)]
        public string Author { get; set; }

        public DateTime AddedDate { get; set; }

        [StringLength(100)]
        public string ImageFilePath { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }
        public string ShortDescription { get; set; }

        public virtual Category Category { get; set; }
    }
}