using System;
using System.ComponentModel.DataAnnotations;

namespace DT102GProject.Models
{
    public class FAQ
    {
        // properties
        [Key]
        public int FAQId { get; set; } // primary key

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        public FAQ()
        {
        }
    }
}
