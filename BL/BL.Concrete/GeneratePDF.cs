using BL.BL.Interfaces;
using BL.DTO;

namespace BL.BL.Concrete
{
    public class GeneratePDF : BaseDbContext, IGeneratePDF
    {
        public void CreatePDF(PersonalDTO _PersonalDTO)
        {
            // var document = new Document();
        }
    }
}
