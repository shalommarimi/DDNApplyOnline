using System;

namespace BL.DTO
{
    public class PersonalDTO
    {

        public int PkApplicantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FkGenderId { get; set; }
        public DateTime DOB { get; set; }
        public string IdNumber { get; set; }
        public int FkNationalityId { get; set; }
        public int FkPopulationId { get; set; }
        public int CellNumber { get; set; }
        public string EmailAddress { get; set; }
        public string DriversLicence { get; set; }
        public int FkMaritalStatusId { get; set; }
        public string HomeLanguage { get; set; }
        public string Prefered { get; set; }
        public string FirstOtherLanguage { get; set; }
        public string SecondOtherLanguage { get; set; }
        public string ThirdOtherLanguage { get; set; }
        public int FkApplicationFieldId { get; set; }
        public int FkApplicationTypeId { get; set; }
        public string Username { get; set; }
        public string New_Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ImagePath { get; set; }


    }
}
