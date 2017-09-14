using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplyOnline.DataAccessLayer
{
    public class Gender
    {
        [Key]
        public int PkGenderId { get; set; }
        public string GenderValue { get; set; }
        public List<Personal> Applicant { get; set; }
     

    }


}
