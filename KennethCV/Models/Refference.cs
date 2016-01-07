using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KennethCV.Models
{
    public class Refference
    {
        [Required(ErrorMessage = "The ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        public string NameRefefence { get; set; }

        [Required(ErrorMessage = "The surname is required.")]
        public string SurnameReference { get; set; }

        [Required(ErrorMessage = "The phone is required")]
        public string PhoneReference { get; set; }

        [Required(ErrorMessage = "The employment is required")]
        public string employmentReference { get; set; }

        [Required(ErrorMessage = "The Work Place is required")]
        public string WorkPlaceReference { get; set; }

        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
            ErrorMessage = "Invalid email address.")]
        public string EmailReference { get; set; }

        [Required(ErrorMessage = "The Work Place is required")]
        public string ComentReference { get; set; }

        public int UserId { get; set; }
    }
}