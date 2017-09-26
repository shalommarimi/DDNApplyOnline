using DAL.DBContext;
using DAL.Entities;
using DAL.Interface;
using System.Linq;

namespace DAL.Repositories
{
    public class EntitiesRepository : IEntities
    {
        public ApplyDbContext dbContext = new ApplyDbContext();

        public IQueryable<Gender> Gender
        {
            get
            {
                return dbContext.Gender;
            }
        }

        public IQueryable<Administrator> _Administrator
        {
            get
            {
                return dbContext.Administrators;
            }
        }

        public IQueryable<ApplicationField> _ApplicationField
        {
            get
            {
                return dbContext.ApplicationField;
            }
        }

        public IQueryable<ApplicationType> _ApplicationType
        {
            get
            {
                return dbContext.ApplicationType;
            }
        }

        public IQueryable<MaritalStatus> _MaritalStatus
        {
            get
            {
                return dbContext.MaritalStatus;
            }
        }

        public IQueryable<Nationality> _Nationality
        {
            get
            {
                return dbContext.Nationalities;
            }
        }

        public IQueryable<NewContent> _NewContent
        {
            get
            {
                return dbContext.NewContents;
            }
        }

        public IQueryable<Personal> _Personals
        {
            get
            {
                return dbContext.Personal;
            }
        }

        public IQueryable<Population> _Popoulation
        {
            get
            {
                return dbContext.Populations;
            }
        }

        public IQueryable<Qualification> _Qualification
        {
            get
            {
                return dbContext.Qualifications;
            }
        }

        public IQueryable<QualificationLevel> _QualificationLevel
        {
            get
            {
                return dbContext.QualificationLevels;
            }
        }

        public IQueryable<Reference> _Reference
        {
            get
            {
                return dbContext.References;
            }
        }

        public IQueryable<Skill> _Skill
        {
            get
            {
                return dbContext.Skills;
            }
        }

        public IQueryable<Subscriber> _Subscriber
        {
            get
            {
                return dbContext.Subscribers;
            }
        }

        public IQueryable<WorkExprience> _WorkExperience
        {
            get
            {
                return dbContext.WorkExpriences;
            }
        }
    }
}
