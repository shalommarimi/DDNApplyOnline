using BL.DTO;

namespace BL.BL.Interfaces
{
    public interface IGeneratePDF
    {
        void CreatePDF(PersonalDTO _PersonalDTO);
    }
}
