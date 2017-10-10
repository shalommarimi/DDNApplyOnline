using BL.DTO;
using DAL.Entities;

namespace BL.BL.Interfaces
{
    public interface IUpdate
    {

        Personal UpdateUser(PersonalDTO _PersonalDTO);
    }
}
