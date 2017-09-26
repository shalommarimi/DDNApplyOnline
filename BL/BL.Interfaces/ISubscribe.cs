using DAL.Entities;

namespace BL.Services
{
    public interface ISubscribe
    {
        void RegisterSubscriber(Subscriber repository);

    }
}
