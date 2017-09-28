using BL.BL.Interfaces;
using BL.Services;
using DAL.DBContext;
using DAL.Entities;

namespace BL.BL.Concrete
{
    public class Register : IRegister
    {

        private readonly IEncryptPassword _EncryptPassword;

        public Register(IEncryptPassword iEncryptPassword)
        {
            _EncryptPassword = iEncryptPassword;
        }


        public void RegisterUser(Personal _Personal)
        {

            using (var _db = new ApplyDbContext())
            {
                _Personal.New_Password = _EncryptPassword.EncryptUserPassword(_Personal.New_Password);
                _db.Personal.Add(_Personal);
                _db.SaveChanges();
            }

        }
    }
}
