namespace BL.Services
{
    public interface IEncryptPassword
    {
        string EncryptUserPassword(string userId);
    }
}
