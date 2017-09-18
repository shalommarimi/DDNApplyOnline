
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Nationality
    {
        [Key]
        public int PkNationalityId { get; set; }
        public string NationalityValue { get; set; }
        public List<Personal> Applicant { get; set; }
    }
}