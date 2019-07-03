using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopMVC.DataAccess.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Insert category title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Insert course description")]
        public string Description { get; set; }

        public string ImageFilePath { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}