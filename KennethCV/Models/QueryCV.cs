using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KennethCV.Models
{
    public class QueryCV
    {
        // Datos del usuario
        public int Id { get; set; }
        public string NameUser { get; set; }
        public string SurnameUser { get; set; }
        public int AgeUser { get; set; }
        public string DocumentUser { get; set; }
        public string PhoneUser { get; set; }
        public string AddressUser { get; set; }
        public string EmailUser { get; set; }

        // Datos de los titulos
        public string TrainingCenter { get; set; }
        public string CertificateName { get; set; }
        public string yearReceived { get; set; }

        // Datos de experiencia laboral
        public string Employment { get; set; }
        public string SinceUntil { get; set; }
        public string Workplace { get; set; }
        public string WorkDetail { get; set; }

        // Datos de las referencias
        public string NameRefefence { get; set; }
        public string SurnameReference { get; set; }
        public string PhoneReference { get; set; }
        public string employmentReference { get; set; }
        public string WorkPlaceReference { get; set; }
        public string EmailReference { get; set; }
        public string ComentReference { get; set; }
    }
}