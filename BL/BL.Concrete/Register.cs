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
        private IGeneratePDF _IGeneratePDF;

        public Register(IEncrypt iEncryptPassword, IGeneratePDF iGeneratePDF)
        {
            _IEncrypt = iEncryptPassword;
            _IGeneratePDF = iGeneratePDF;
        }


        public void RegisterUser(PersonalDTO _PersonalDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDTO, Personal>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);



            //Hashing Password and Setting IsDeleted default value
            model.New_Password = _IEncrypt.EncryptPassword(model.New_Password);
            model.ConfirmPassword = _IEncrypt.EncryptPassword(model.ConfirmPassword);
            model.IsDeleted = false;



            try
            {
                db.Personal.Add(model);
                db.SaveChanges();
                _IGeneratePDF.CreatePDF(_PersonalDTO);
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}
