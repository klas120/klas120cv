using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KennethCV.Models
{
    public class User
    {
        
        [Required(ErrorMessage = "The ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        public string NameUser { get; set; }

        [Required(ErrorMessage = "The surname is required.")]
        public string SurnameUser { get; set; }

        [Range(10, 70, ErrorMessage = "A number between 10 and 70.")]
        public int AgeUser { get; set; }

        [Required(ErrorMessage = "The document is required")]
        public string DocumentUser { get; set; }

        [Required(ErrorMessage = "The phone is required")]
        public string PhoneUser { get; set; }

        [Required(ErrorMessage = "The address is required")]
        public string AddressUser { get; set; }

        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
            ErrorMessage = "Invalid email address.")]
        public string EmailUser { get; set; }

        public virtual ICollection<Refference> Refferences { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
