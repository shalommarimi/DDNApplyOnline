
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Qualification
    {
        [Key]
        public int PkQualificationId { get; set; }



        [Display(Name = "Qualification Field")]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public string QualField { get; set; }


        [Display(Name = "Qualification Level")]
        public int FkQualLevelId { get; set; }
        [ForeignKey("FkQualLevelId")]
        public QualLevel QualLevels { get; set; }



        [Display(Name = "Institution")]
        public string Institution { get; set; }

        [Display(Name = "Year Obtained")]
        public DateTime QualYearObtained { get; set; }

        public int FkApplicantId { get; set; }
        [ForeignKey("FkApplicantId")]
        public Personal PersonalInformations { get; set; }


    }
}