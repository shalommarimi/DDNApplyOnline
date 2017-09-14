using ApplyOnline.DataAccessLayer;

namespace BL
{
    interface IApplicant
    {

        void CreateApplicant(Personal personal);
        void UpdateApplicant(Personal personal);

    }

}
