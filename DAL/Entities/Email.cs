using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Email
    {


        [Required]
        [EmailAddress]
        public string Recipient { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Enquiry Message")]
        public string Message { get; set; }



    }
}