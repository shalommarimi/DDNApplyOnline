using AutoMapper;
using BL.BL.Interfaces;
using BL.DTO;
using BL.Services;
using DAL.Entities;

namespace BL.BL.Concrete
{
    public class Register : BaseDbContext, IRegister
    {

        private readonly IEncrypt _IEncrypt;
        private readonly IFileService _IFileService;
        private readonly IGeneratePDF _IGeneratePDF;

        public Register(IEncrypt iEncryptPassword, IGeneratePDF iGeneratePDF, IFileService iFileService)
        {
            _IEncrypt = iEncryptPassword;
            _IGeneratePDF = iGeneratePDF;
            _IFileService = iFileService;
        }


        public void RegisterUser(PersonalDTO _PersonalDTO)
        {

            //Mapping
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDTO, Personal>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);



            //Hashing Password and Setting IsDeleted default value
            model.NewPassword = _IEncrypt.EncryptPassword(model.NewPassword);
            model.ConfirmPassword = _IEncrypt.EncryptPassword(model.ConfirmPassword);
            //model.ImagePath = ConfigurationManager.AppSettings["defaultImagePath"].ToString();
            model.IsDeleted = false;



            try
            {
                //Adds and Saves into DB
                db.Personal.Add(model);
                db.SaveChanges();

                //Generates PDF
                _IGeneratePDF.CreatePDF(_PersonalDTO);

            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}
