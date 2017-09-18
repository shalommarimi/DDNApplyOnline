using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class QualLevel
    {
        [Key]
        public int PkQualLevelId { get; set; }
        public string QualLevelValue { get; set; }
        public List<Qualification> Qualifications { get; set; }
    }
}