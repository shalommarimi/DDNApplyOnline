
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class MaritalStatus
    {
        [Key]
        public int PkMaritalStatusId { get; set; }
        public string MaritalStatusValue { get; set; }
        public List<Personal> Applicant { get; set; }
    }
}