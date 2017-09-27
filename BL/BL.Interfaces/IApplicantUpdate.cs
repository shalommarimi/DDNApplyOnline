using DAL.Entities;

namespace BL.BL.Interfaces
{
    public interface IApplicantUpdate
    {

        Personal Update(int id, Personal _Person);
    }
}
