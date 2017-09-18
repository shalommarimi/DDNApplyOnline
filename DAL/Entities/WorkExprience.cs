
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class WorkExprience
    {
        [Key]
        public int PkWorkId { get; set; }

        [Display(Name = "Company")]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public string WorkCompany { get; set; }


        [Display(Name = "Job Title")]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public string WorkTitle { get; set; }

        [Display(Name = "Started From")]
        public DateTime WorkStartedFrom { get; set; }

        [Display(Name = "To|To Date")]
        public DateTime WorkTo { get; set; }

        [Display(Name = "Reason For Leaving")]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public string WhyQuitWork { get; set; }


        public int FkApplicantId { get; set; }
        [ForeignKey("FkApplicantId")]
        public Personal PersonalInformations { get; set; }
    }
}