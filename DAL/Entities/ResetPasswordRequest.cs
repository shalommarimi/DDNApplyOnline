
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class ResetPasswordRequest
    {
        [Key]
        public int PkRequestId { get; set; }
        public Guid RequestGUID { get; set; }

        public int FkApplicantId { get; set; }
        [ForeignKey("FkApplicantId")]
        public Personal PersonalInformations { get; set; }
    }
}