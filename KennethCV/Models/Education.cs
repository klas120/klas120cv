using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KennethCV.Models
{
    public class Education
    {
        [Required(ErrorMessage = "The ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The training center is required.")]
        public string TrainingCenter { get; set; }

        [Required(ErrorMessage = "The certificate is required.")]
        public string CertificateName { get; set; }

        // Grade level isn't obligarory
        public string GradeLevel { get; set; }

        [Required(ErrorMessage = "The year received is required")]
        public string yearReceived { get; set; }

        public int UserId { get; set; }
    }
}