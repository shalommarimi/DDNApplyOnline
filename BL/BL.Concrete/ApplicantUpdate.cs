using BL.BL.Interfaces;
using DAL.DBContext;
using DAL.Entities;
using System.Data.Entity;

namespace BL.BL.Concrete
{
    public class ApplicantUpdate : IApplicantUpdate
    {
        public Personal Update(int id, Personal _Personal)
        {
            using (var db = new ApplyDbContext())
            {
                db.Entry(_Personal).State = EntityState.Modified;
                db.SaveChanges();
            }

            return _Personal;
        }
    }
}
