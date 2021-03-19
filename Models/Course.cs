using System;
using System.ComponentModel.DataAnnotations;

namespace DT102GProject.Models
{
    public class Course
    {
        // properties
        [Key]
        public int CourseId { get; set; } // primary key

        [Required]
        public string Title { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Length { get; set; }

        [Required]
        public string Level { get; set; }

        [Required]
        public string Description { get; set; }

        public Course()
        {
        }
    }
}
