using DAL.Entities;
using System.Linq;

namespace DAL.Interface
{
    public interface IEntities
    {
        IQueryable<Personal> _Personals { get; }
        IQueryable<Administrator> _Administrator { get; }
        IQueryable<ApplicationField> _ApplicationField { get; }
        IQueryable<ApplicationType> _ApplicationType { get; }
        IQueryable<Gender> Gender { get; }
        IQueryable<MaritalStatus> _MaritalStatus { get; }
        IQueryable<Nationality> _Nationality { get; }
        IQueryable<NewContent> _NewContent { get; }
        IQueryable<Population> _Popoulation { get; }
        IQueryable<Qualification> _Qualification { get; }
        IQueryable<QualificationLevel> _QualificationLevel { get; }
        IQueryable<Reference> _Reference { get; }
        IQueryable<Skill> _Skill { get; }
        IQueryable<Subscriber> _Subscriber { get; }
        IQueryable<WorkExprience> _WorkExperience { get; }

    }
}
