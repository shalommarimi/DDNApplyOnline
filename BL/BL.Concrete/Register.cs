using BL.BL.Interfaces;
using BL.Services;
using DAL.DBContext;
using DAL.Entities;

namespace BL.BL.Concrete
{
    public class Register : IRegister
    {

        private readonly IEncrypt _IEncrypt;

        public Register(IEncrypt iEncryptPassword)
        {
            _IEncrypt = iEncryptPassword;
        }


        public void RegisterUser(Personal _Personal)
        {

            using (var _db = new ApplyDbContext())
            {
                _Personal.New_Password = _IEncrypt.EncryptPassword(_Personal.New_Password);
                _Personal.ConfirmPassword = _IEncrypt.EncryptPassword(_Personal.ConfirmPassword);
                _Personal.IsDeleted = false;
                _db.Personal.Add(_Personal);
                _db.SaveChanges();
            }

        }
    }
}
