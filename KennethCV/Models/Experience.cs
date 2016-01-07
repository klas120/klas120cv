using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KennethCV.Models
{
    public class Experience
    {
        [Required(ErrorMessage = "The ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The employment is required.")]
        public string Employment { get; set; }

        [Required(ErrorMessage = "The SinceUntil is required.")]
        public string SinceUntil { get; set; }

        [Required(ErrorMessage = "The Workplace is required")]
        public string Workplace { get; set; }

        [Required(ErrorMessage = "The work datail is required")]
        public string WorkDetail { get; set; }

        public int UserId { get; set; }
    }
}