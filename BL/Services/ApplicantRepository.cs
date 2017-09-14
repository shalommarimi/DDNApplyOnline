using ApplyOnline.DataAccessLayer;
using ApplyOnline.DataContext;
using System;

namespace BL.Services
{
    public class ApplicantRepository : IApplicant
    {
        private readonly ApplicantsDbContext _dbContext;

        public ApplicantRepository(ApplicantsDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void CreateApplicant(Personal personal)
        {
            _dbContext._Personal.Add(personal);
            _dbContext.SaveChanges();

        }



        public void UpdateApplicant(Personal personal)
        {
            throw new NotImplementedException();
        }
    }
}
