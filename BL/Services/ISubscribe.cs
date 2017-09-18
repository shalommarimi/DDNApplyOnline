
using DAL.Entities;

namespace BL
{
    public interface ISubscribe
    {
        void RegisterSubscriber(SubscriberInformation subscriber);

    }
}
