
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Population
    {
        [Key]
        public int PkPopulationId { get; set; }
        public string PopulationValue { get; set; }
        public List<Personal> Applicant { get; set; }
    }
}