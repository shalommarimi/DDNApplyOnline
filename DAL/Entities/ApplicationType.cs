
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class ApplicationType
    {
        [Key]
        public int PkApplicationTypeId { get; set; }

        [Required]
        [Display(Name = "Application Type Name")]
        public string ApplicationTypeName { get; set; }
        public List<Personal> Applicant { get; set; }
    }
}