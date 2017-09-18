using DAL.Entities;
using System.Data.Entity;

namespace ApplyOnline.DataContext
{
    public class ApplicantsDbContext : DbContext
    {
        public ApplicantsDbContext() : base("ApplicantsDbContext")
        {
            Database.SetInitializer(new SeedDataContext());

        }

        public virtual DbSet<Personal> _Personal { get; set; }
        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<ApplicationField> ApplicationField { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<SubscriberInformation> Subscribers { get; set; }
        public virtual DbSet<NewContent> NewContent { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<AdministrationCredentials> Admin { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<QualLevel> QualLevels { get; set; }
        public virtual DbSet<Population> Populations { get; set; }
        public virtual DbSet<Files> UploadFiles { get; set; }
        public virtual DbSet<WorkExprience> WorkExpriences { get; set; }


    }
}