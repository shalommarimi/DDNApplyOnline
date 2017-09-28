using DAL.Entities;

namespace BL.BL.Interfaces
{
    public interface IUpdate
    {

        Personal UpdateUser(int id, Personal _Person);
    }
}
