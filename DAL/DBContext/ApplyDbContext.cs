using ApplyOnline.DataContext;
using DAL.Entities;
using System.Data.Entity;

namespace DAL.DBContext
{
    public class ApplyDbContext : DbContext
    {

        public ApplyDbContext() : base("ApplyDbContext")
        {
            Database.SetInitializer(new SeedDataContext());

        }

        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<ApplicationField> ApplicationField { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<NewContent> NewContents { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<QualificationLevel> QualificationLevels { get; set; }
        public virtual DbSet<Population> Populations { get; set; }
        public virtual DbSet<Files> UploadFiles { get; set; }
        public virtual DbSet<WorkExprience> WorkExpriences { get; set; }
    }
}
