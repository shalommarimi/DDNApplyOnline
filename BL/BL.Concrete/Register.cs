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

        public Register(IEncrypt iEncryptPassword)
        {
            _IEncrypt = iEncryptPassword;
        }


        public void RegisterUser(PersonalDTO _PersonalDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDTO, Personal>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);

            model.New_Password = _IEncrypt.EncryptPassword(model.New_Password);
            model.ConfirmPassword = _IEncrypt.EncryptPassword(model.ConfirmPassword);


            model.IsDeleted = false;
            db.Personal.Add(model);
            db.SaveChanges();
        }
    }
}
